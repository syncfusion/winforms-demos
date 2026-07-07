using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Syncfusion.WinForms.AIAssistView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace AssistViewDemo
{
#if NETCOREAPP
    [SupportedOSPlatform("windows")]
#endif
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields and property
        AIAssistChatService service;
        private System.Threading.CancellationTokenSource cts;

        private ObservableCollection<object> chats;
        public ObservableCollection<object> Chats
        {
            get
            {
                return this.chats;
            }
            set
            {
                this.chats = value;
                RaisePropertyChanged("Chats");
            }
        }

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Author currentUser;
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        private bool showTypingIndicator;
        public bool ShowTypingIndicator
        {
            get
            {
                return this.showTypingIndicator;
            }
            set
            {
                this.showTypingIndicator = value;
                RaisePropertyChanged("ShowTypingIndicator");
            }
        }

        private ObservableCollection<ReservationSuggestion> suggestion;
        public ObservableCollection<ReservationSuggestion> Suggestion
        {
            get
            {
                if(this.suggestion == null)
                {
                    this.suggestion = new ObservableCollection<ReservationSuggestion>();
                }

                return this.suggestion;
            }
            set
            {
                this.suggestion = value;
                RaisePropertyChanged("Suggestion");
            }
        }

        private TypingIndicator typingIndicator;
        public TypingIndicator TypingIndicator
        {
            get
            {
                return this.typingIndicator;
            }
            set
            {
                this.typingIndicator = value;
                RaisePropertyChanged("TypingIndicator");
            }
        }

        #endregion

        public ViewModel()
        {
            this.Chats = new ObservableCollection<object>();
            this.CurrentUser = new Author() { Name = "John" };
            service = new AIAssistChatService();
            service?.Initialize();

            skipNextNotify = true;
            AddInitialBotMessage();
            skipNextNotify = false;
            
            this.Chats.CollectionChanged += Chats_CollectionChanged;
        }

        public void CancelAIRequest()
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }
        }

        private void AddInitialBotMessage()
        {
            // Use the name configured in ResponseManager and present country suggestions as the first message
            var manager = ResponseManager.Instance;
            string initialMessage = "Welcome " + manager.Name + "! Where would you like to go?";
            var initialBotMessage = new TextMessage
            {
                Author = new Author { Name = "Bot" , AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") },
                DateTime = DateTime.Now,
                Text = initialMessage,

            };

            this.chats.Add(initialBotMessage);
            RaisePropertyChanged(nameof(Chats));

            // Populate initial suggestions with available countries
            Suggestion.Clear();
            foreach (var country in manager.Countries)
            {
                Suggestion.Add(new ReservationSuggestion { DisplayText = country.Name, Action = SuggestionAction.SendMessage });
            }

            // Prepare ResponseManager to accept the country as the first booking input
            manager.BeginBooking();
        }

        private bool skipNextNotify = false;

        public void AddInteractivelaceholder(string text)
        {
            skipNextNotify = true;
            Chats.Add(new TextMessage
            {
                Author = this.currentUser,
                DateTime = DateTime.Now,
                Text = text,
            });
            skipNextNotify = false;
        }

        public void SendUserMessage(string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            Chats.Add(new TextMessage
            {
                Author = this.currentUser,
                DateTime = DateTime.Now,
                Text = text,
            });
        }

        private async void Chats_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (skipNextNotify || e.Action != System.Collections.Specialized.NotifyCollectionChangedAction.Add) return;

            var item = e.NewItems?[0] as TextMessage;
            if (item != null)
            {
                if (item.Author.Name == currentUser.Name)
                {
                    try
                    {
                        Suggestion.Clear();
                        ShowTypingIndicator = true;

                        cts = new System.Threading.CancellationTokenSource();
                        await service.NonStreamingChat(item.Text, cts.Token);

                        var bundle = ResponseManager.GetResponseForQuery(item.Text);

                        Chats.Add(new TextMessage
                        {
                            Author = new Author { Name = "Bot", AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") },
                            DateTime = DateTime.Now,
                            Text = bundle.BotResponse,
                        });

                        foreach (var suggestion in bundle.Suggestions)
                        {
                            Suggestion.Add(suggestion);
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        Chats.Add(new TextMessage
                        {
                            Author = new Author { Name = "Bot", AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") },
                            DateTime = DateTime.Now,
                            Text = "Request stopped by user.",
                        });
                    }
                    finally
                    {
                        ShowTypingIndicator = false;
                        cts?.Dispose();
                        cts = null;
                    }
                }
            }
        }

        public class AIAssistChatService
        {
            IChatCompletionService gpt;
            Kernel kernel;
            private string OPENAI_KEY = string.Empty; // configure for real AI service

            private string OPENAI_MODEL = string.Empty;

            private string API_ENDPOINT = string.Empty;

            public string Response { get; set; }
            public async Task Initialize()
            {
                if (!string.IsNullOrWhiteSpace(OPENAI_KEY) &&
                    !string.IsNullOrWhiteSpace(OPENAI_MODEL) &&
                    !string.IsNullOrWhiteSpace(API_ENDPOINT))
                {
                    try
                    {
                        IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
                        kernelBuilder.AddAzureOpenAIChatCompletion(
                            deploymentName: OPENAI_MODEL,
                            apiKey: OPENAI_KEY,
                            endpoint: API_ENDPOINT,
                            modelId: "gpt-4"
                        );

                        kernel = kernelBuilder.Build();
                        gpt = kernel.GetRequiredService<IChatCompletionService>();
                    }
                    catch (Exception)
                    {
                        // If initialization fails, gpt will remain null
                        gpt = null;
                    }
                }
            }

            /// <summary>
            /// Performs a non-streaming chat request with the AI service.
            /// </summary>
            /// <param name="line">The user's query.</param>
            /// <returns>A task representing the completion of the chat request.</returns>
            public async Task NonStreamingChat(string line, System.Threading.CancellationToken token = default)
            {
                Response = string.Empty;

                // Check if credentials are missing or initialization failed
                if (string.IsNullOrWhiteSpace(OPENAI_KEY) ||
                    string.IsNullOrWhiteSpace(OPENAI_MODEL) ||
                    string.IsNullOrWhiteSpace(API_ENDPOINT) ||
                    gpt == null)
                {
                    await Task.Delay(1000, token); // Simulate network delay for realism
                    return;
                }

                try
                {
                    var response = await gpt.GetChatMessageContentAsync(line, cancellationToken: token);
                    Response = response.ToString();
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    Response = "Error connecting to AI service: " + ex.Message;
                }
            }

            private List<ChatData> dummyData;

            public class ChatData
            {
                public string Query { get; set; }
                public string Response { get; set; }
            }

        }
    }
}

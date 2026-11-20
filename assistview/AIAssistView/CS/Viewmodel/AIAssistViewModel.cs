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
    public class AIAssistViewModel : INotifyPropertyChanged
    {
        #region Fields and property
        AIAssistChatService<Response> service;
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

        private IEnumerable<string> suggestion;
        public IEnumerable<string> Suggestion
        {
            get
            {
                if(this.suggestion == null)
                {
                    this.suggestion = new ObservableCollection<string>();
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

        #region Public method

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAssistViewModel"/> class.
        /// </summary>
        public AIAssistViewModel()
        {
            this.Chats = new ObservableCollection<object>();
            this.Chats.CollectionChanged += Chats_CollectionChanged;
            this.Suggestion = new List<string>();
            this.CurrentUser = new Author() { Name = "John" };
        }

        public void CancelAIRequest()
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }
        }

        /// <summary>
        /// Updates the AI service credentials and re-initializes service.
        /// </summary>
        /// <param name="key">The API key.</param>
        /// <param name="model">The model name.</param>
        /// <param name="endpoint">The API endpoint.</param>
        public async void UpdateAI(string key, string model, string endpoint)
        {
            if (service != null)
            {
                await service.UpdateAI(key, model, endpoint);
            }
        }

        /// <summary>
        /// Initializes the AI service and sets up initial chat data.
        /// </summary>
        public async void InitAI()
        {
            string goalSuggest = "How do I set daily goals in my work day?";
            string goalSolution = "To stay focused and productive, try these steps for setting daily goals:\n\n" +
                            "- **Identify Priorities**: List the most important tasks based on deadlines or significance.\n" +
                            "- **Break Down Tasks**: Split larger tasks into smaller, manageable steps.\n" +
                            "- **Set SMART Goals**: Make sure goals are Specific, Measurable, Achievable, Relevant, and Time-bound.\n" +
                            "- **Time Blocking**: Allocate specific times for each task to stay organized and on track.\n" +
                            "Would you like more tips on any of these steps?";

            string toolSuggest = "What tools or apps can help me prioritize tasks?";
            string toolSolution = "Here are some tools to help you prioritize tasks effectively:\n\n"
                + "- **Google Keep**: For simple note-taking and task organization with labels and reminders.\n"
                + "- **Scoro**: A project management tool for streamlining activities and team collaboration.\n"
                + "- **Evernote**: Great for note-taking, to-do lists, and reminders.\n"
                + "- **Todo List**: A powerful task manager for setting priorities and tracking progress.\n"
                + "Are you looking for tools to manage a specific type of task or project?";

            service = new AIAssistChatService<Response>
            {
                Requirement = string.Format("I am an AI assistant that helps people find information, " +
                "Give required information in markdown format along with next 3 possible questions the user might ask, " +
                "send the response in json schema.{0}", GenerateJsonSchema(typeof(Response))),
                OfflineContent = new Dictionary<string, string>
                {
                    { goalSuggest, goalSolution},
                    { toolSuggest, toolSolution}
                },
            };

            await service.Initialize();
            Suggestion = new List<string>(service.OfflineContent.Keys);
            Chats.Add(new TextMessage
            {
                Author = new Author { Name = "Bot", AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") },
                DateTime = DateTime.Now,
                Text = "I am an AI assistant.\n" + "Ask anything you want to know",
            });
        }

        public static string GenerateJsonSchema(Type type)
        {
            var store =
                    @"{
                      ""type"": ""object"",
                      ""properties"": {
                        ""AIResponse"": {
                          ""type"": [
                            ""string"",
                            ""null""
                          ]
                        },
                        ""Suggestions"": {
                          ""type"": [
                            ""array"",
                            ""null""
                          ],
                          ""items"": {
                            ""type"": [
                              ""string"",
                              ""null""
                            ]
                          }
                        }
                      },
                      ""required"": [
                        ""AIResponse"",
                        ""Suggestions""
                      ]
                    }";
            return store;
        }


        public class Response
        {
            public string AIResponse { get; set; }
            public List<string> Suggestions { get; set; }
        }

        private bool skipNextNotify = false;

        /// <summary>
        /// Adds an interactive placeholder message to the chat collection.
        /// </summary>
        /// <param name="text">The text content for the placeholder message.</param>
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

        /// <summary>
        /// Adds a user's message to the chat collection.
        /// </summary>
        /// <param name="text">The text content of the message.</param>
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
                        ShowTypingIndicator = true;
                        cts = new System.Threading.CancellationTokenSource();
                        await service.NonStreamingChat(item.Text, cts.Token);

                        Chats.Add(new TextMessage
                        {
                            Author = new Author { Name = "Bot", AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") },
                            DateTime = DateTime.Now,
                            Text = service.Response,
                        });
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
                        if (service.Suggestion != null)
                            Suggestion = new List<string>(service.Suggestion);

                        cts?.Dispose();
                        cts = null;
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// Represents a service for managing AI chat interactions.
        /// </summary>
        /// <typeparam name="T">The response type model.</typeparam>
        public class AIAssistChatService<T> where T : Response
        {
            IChatCompletionService gpt;
            Kernel kernel;

            // configure for real AI service
            private string OPENAI_KEY = string.Empty;
            private string OPENAI_MODEL = string.Empty;
            private string API_ENDPOINT = string.Empty;

            public string Requirement { get; set; }
            public Dictionary<string, string> OfflineContent { get; set; } = new Dictionary<string, string>();

            private ObservableCollection<string> suggestion;
            public ObservableCollection<string> Suggestion
            {
                get
                {
                    if (this.suggestion == null)
                    {
                        this.suggestion = new ObservableCollection<string>();
                    }

                    return this.suggestion;
                }
                set
                {
                    this.suggestion = value;
                }
            }

            public string Response { get; set; }

            #region AI Service Methods

            /// <summary>
            /// Updates the AI configuration and re-initializes the service.
            /// </summary>
            /// <param name="key">The API key.</param>
            /// <param name="model">The model name.</param>
            /// <param name="endpoint">The API endpoint.</param>
            /// <returns>A task representing the initialization process.</returns>
            public async Task UpdateAI(string key, string model, string endpoint)
            {
                this.OPENAI_KEY = key;
                this.OPENAI_MODEL = model;
                this.API_ENDPOINT = endpoint;
                await Initialize();
            }

            /// <summary>
            /// Initializes the AI service and kernel.
            /// </summary>
            /// <returns>A task representing the initialization process.</returns>
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

            #endregion

            /// <summary>
            /// Generates a simple JSON schema for the AI response model.
            /// </summary>
            /// <param name="type">The type of the response.</param>
            /// <returns>The generated JSON schema string.</returns>
            public static string GenerateJsonSchema(Type type)
            {
                var store =
                            @"{
                          ""type"": ""object"",
                          ""properties"": {
                            ""AIResponse"": {
                              ""type"": [
                                ""string"",
                                ""null""
                              ]
                            },
                            ""Suggestions"": {
                              ""type"": [
                                ""array"",
                                ""null""
                              ],
                              ""items"": {
                                ""type"": [
                                  ""string"",
                                  ""null""
                                ]
                              }
                            }
                          },
                          ""required"": [
                            ""AIResponse"",
                            ""Suggestions""
                          ]
                        }";
                return store;
            }

            /// <summary>
            /// Performs a non-streaming chat request with the AI service.
            /// </summary>
            /// <param name="line">The user's query.</param>
            /// <returns>A task representing the completion of the chat request.</returns>
            public async Task NonStreamingChat(string line, System.Threading.CancellationToken token = default)
            {
                Response = string.Empty;
                Suggestion.Clear();

                // Check if credentials are missing or initialization failed
                if (string.IsNullOrWhiteSpace(OPENAI_KEY) ||
                    string.IsNullOrWhiteSpace(OPENAI_MODEL) ||
                    string.IsNullOrWhiteSpace(API_ENDPOINT) ||
                    gpt == null)
                {
                    await Task.Delay(1000, token); // Simulate network delay for realism
                    if (OfflineContent.ContainsKey(line))
                    {
                        Response = OfflineContent[line];
                    }
                    else
                    {
                        Response = "I'm sorry, I don't have an offline response for that. Try asking one of the suggested questions.";
                    }
                    
                    // Add some dummy suggestions for next steps
                    Suggestion.Add("How do I set daily goals in my work day?");
                    Suggestion.Add("What tools or apps can help me prioritize tasks?");
                    return;
                }

                try
                {
                    var response = await gpt.GetChatMessageContentAsync(line, cancellationToken: token);
                    Response = response.ToString();
                    // In a real scenario, you'd parseSuggestions from the AI response here
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    Response = "Error connecting to AI service: " + ex.Message;
                    this.Suggestion.Clear();
                    this.Suggestion.Add("Retry Connection");
                    this.Suggestion.Add("Check API Settings");
                }
            }
        }
    }
}

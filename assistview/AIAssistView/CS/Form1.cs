using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.AIAssistView;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms.Integration;
using System.Windows;
using AISettingsWindow;
using System.Runtime.Versioning;
using Syncfusion.Windows.Forms;

namespace AssistViewDemo
{
#if NETCOREAPP
    [SupportedOSPlatform("windows")]
#endif
    public partial class Form1 : Form
    {
        AIAssistViewModel viewModel = new AIAssistViewModel();

        private Dictionary<TextMessage, ElementHost> botControlMapping = new Dictionary<TextMessage, ElementHost>();
        private Image botAvatarImage;
        private Image bannerImage;

#if NETFRAMEWORK
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern int GetDpiForWindow(IntPtr hWnd);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern IntPtr GetDC(IntPtr hWnd);

    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    private const int LOGPIXELSX = 88;
    private const int LOGPIXELSY = 90;
#endif

        public Form1()
        {
            InitializeComponent();
            sfaiAssistView1.DataBindings.Add("Messages", viewModel, "Chats", true, DataSourceUpdateMode.OnPropertyChanged);
            sfaiAssistView1.DataBindings.Add("ShowTypingIndicator", viewModel, "ShowTypingIndicator", true, DataSourceUpdateMode.OnPropertyChanged);
            sfaiAssistView1.DataBindings.Add("Suggestions", viewModel, "Suggestion", true, DataSourceUpdateMode.OnPropertyChanged);

            viewModel.InitAI();

            if (viewModel.CurrentUser != null && !string.IsNullOrEmpty(sfaiAssistView1.User.Name))
            {
                viewModel.CurrentUser = sfaiAssistView1.User;
            }
            else
            {
                sfaiAssistView1.User = viewModel.CurrentUser;
            }

            sfaiAssistView1.Dock = DockStyle.Fill;
            sfaiAssistView1.EnableStopResponding = true;
			sfaiAssistView1.IsResponseToolBarVisible = true;
            sfaiAssistView1.ShowTypingIndicator = viewModel.ShowTypingIndicator;
            viewModel.PropertyChanged += ViewModel_PropertyChanged;

            BannerTemplate();

            botAvatarImage = Image.FromFile(@"Asset\AI_Assist.png");
            sfaiAssistView1.TypingIndicator.Author = new Author() { Name = "Bot", AvatarImage = botAvatarImage };
            sfaiAssistView1.TypingIndicator.DisplayText = "Typing";
            sfaiAssistView1.SuggestionSelected += OnSuggestionSelected;
            sfaiAssistView1.StopRespondingButtonClicked += SfaiAssistView1_StopResponding;
            sfaiAssistView1.ResponseToolBarItemClicked += SfaiAssistView1_ResponseToolBarItemClicked;
            sfaiAssistView1.PromptRequest += Chat_PromptRequest;

            viewModel.Chats.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    UpdateButtonState();
                }
            };

            SetupInputToolbar();
            WireUpEventHandlers();

            Func<object, Control> botCustomView = (messageModel) =>
            {
                var textMessage = messageModel as TextMessage;
                if (textMessage == null) return null;

                var wpfHostControl = new WPFApplication();
                wpfHostControl.MarkDownText = textMessage.Text;

                ElementHost wpfHost = new ElementHost()
                {
                    AutoSize = false,
                    BackColorTransparent = true,
                    Child = wpfHostControl
                };

                botControlMapping[textMessage] = wpfHost;

                UpdateHostControlSize(textMessage, wpfHost);

                wpfHostControl.Dispatcher.BeginInvoke(new Action(() =>
                {
                    UpdateHostControlSize(textMessage, wpfHost);
                }), System.Windows.Threading.DispatcherPriority.Background);

                return wpfHost;
            };

            sfaiAssistView1.SetMessageView(isBot: true, botCustomView);

            this.Resize += Form1_Resize;
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void SetupInputToolbar()
        {
            sfaiAssistView1.IsInputToolbarVisible = true;
            // Create toolbar items collection
            sfaiAssistView1.InputToolbarItems = new ObservableCollection<InputToolbarItem>
            {
                new InputToolbarItem
                {
                    Name = "Attach",
                    ToolTip = "Attach File",
                    Icon = Image.FromFile(@"Asset\Attachment-02-WF.png"),
                    IsVisible = true
                }
            };

            // Initialize attachments collection
            sfaiAssistView1.Attachments = new ObservableCollection<AttachmentItem>();

        }


        private void WireUpEventHandlers()
        {
            // Handle toolbar item clicks
            sfaiAssistView1.InputToolbarItemClicked += OnInputToolbarItemClicked;
        }
        private void OnInputToolbarItemClicked(object sender, InputToolbarItemClickedEventArgs args)
        {
            var item = args.ToolbarItem;

            switch (item.Name)
            {
                case "Attach":
                    HandleAttachFile();
                    break;
            }
        }

        private async void HandleAttachFile()
        {
            // Show file picker dialog
            var dialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                Multiselect = false,
                Title = "Select a file to attach"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                var fi = new System.IO.FileInfo(dialog.FileName);
                // Validate file size (example: max 10 MB)
                const long MaxFileSize = 10 * 1024 * 1024;
                if (fi.Length > MaxFileSize)
                {
                    ShowToastOptions(ToastSeverity.Error, $"File size exceeds 10 MB limit. ({FormatFileSize(fi.Length)})");
                    return;
                }

                // Add to pending attachments (shows card in input header)
                var attachment = new AttachmentItem
                {
                    FileName = fi.Name,
                    FileSize = FormatFileSize(fi.Length),
                    FilePath = filePath,  // Local file path for reference
                    FileExtension = fi.Extension,  // e.g. ".pdf", ".docx"
                    FileContent = null,  // Lazy-loaded; set to file bytes if needed
                    FilePreviewIcon = null,  // Optional thumbnail; falls back to FileIcon if not set
                };

                ShowToastOptions(ToastSeverity.Success, "Uploades successfully.");

                sfaiAssistView1.Attachments.Add(attachment);
            }
        }

        private void ShowToastOptions(ToastSeverity status, string message)
        {
            sfaiAssistView1.ShowNotification(new ToastOptions
            {
                Severity = status,
                Message = message
            });
        }

        public void Chat_PromptRequest(object sender, PromptRequestEventArgs e)
        {
            e.Handled = true;
            var textMessage = e.Message as TextMessage;
            viewModel.Chats.Add(textMessage);
            sfaiAssistView1.Attachments.Clear();
        }

        private static string FormatFileSize(long bytes)
        {
            const long KB = 1024;
            const long MB = KB * 1024;
            const long GB = MB * 1024;

            if (bytes >= GB)
                return $"{bytes / (double)GB:F2} GB";
            if (bytes >= MB)
                return $"{bytes / (double)MB:F2} MB";
            if (bytes >= KB)
                return $"{bytes / (double)KB:F2} KB";

            return $"{bytes} B";
        }

        private void UpdateButtonState()
        {
            var messages = viewModel.Chats.OfType<TextMessage>().ToList();
            var botMessages = messages.Where(m => m.Author.Name == "Bot").ToList();
            var latestBot = botMessages.LastOrDefault();

            foreach (var chat in botMessages)
            {
                bool shouldShow = (chat == latestBot);
                sfaiAssistView1.SetToolBarItemVisibility(chat, "Regenerate", shouldShow);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Resize -= Form1_Resize;
            viewModel.PropertyChanged -= ViewModel_PropertyChanged;
            sfaiAssistView1.SuggestionSelected -= OnSuggestionSelected;
            sfaiAssistView1.StopRespondingButtonClicked -= SfaiAssistView1_StopResponding;
            sfaiAssistView1.ResponseToolBarItemClicked -= SfaiAssistView1_ResponseToolBarItemClicked;

            foreach (var kvp in botControlMapping)
            {
                if (kvp.Value is ElementHost host)
                {
                    if (host.Child is IDisposable disposableChild)
                        disposableChild.Dispose();
                    host.Child = null;
                    host.Dispose();
                }
            }
            botControlMapping.Clear();

            botAvatarImage?.Dispose();
            bannerImage?.Dispose();

            if (viewModel is IDisposable disposableViewModel)
            {
                disposableViewModel.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAISettings();
        }

        private void ShowAISettings()
        {
            var demoViewModel = new DemoBrowserViewModel();
            demoViewModel.EndPoint = AISettings.EndPoint;
            demoViewModel.ModelName = AISettings.ModelName;
            demoViewModel.Key = AISettings.Key;

            var settingsForm = new AISettingsForm(demoViewModel);
            settingsForm.StartPosition = FormStartPosition.CenterParent;
            if (settingsForm.ShowDialog(this) == DialogResult.OK)
            {
                viewModel.UpdateAI(demoViewModel.Key, demoViewModel.ModelName, demoViewModel.EndPoint);
            }
        }

        public bool isUpdating = false;
        private void UpdateHostControlSize(TextMessage message, ElementHost wpfHost)
        {
            if (isUpdating) return;

            if(wpfHost.Child is WPFApplication wpfApplication)
            {
                try
                {
                    isUpdating = true;
                    double maxWidth = Math.Max(100, (double)this.ClientSize.Width * 0.65);
                    wpfApplication.MaxWidth = maxWidth;

                    wpfApplication.Measure(new System.Windows.Size(maxWidth, double.PositiveInfinity));
                    wpfApplication.Arrange(new Rect(new System.Windows.Point(0,0), wpfApplication.DesiredSize));

                    using (Graphics graphics = this.CreateGraphics())
                    {
                        float dpiX;
                        float dpiY;
#if NETCOREAPP
                        dpiX = this.DeviceDpi;
                        dpiY = this.DeviceDpi;
#else
                    try
                    {
                        int windowDpi = GetDpiForWindow(this.Handle);
                        if (windowDpi > 0)
                        {
                            dpiX = windowDpi;
                            dpiY = windowDpi;
                        }
                        else
                        {
                            var dpiProperty = this.GetType().GetProperty("DeviceDpi", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                            if (dpiProperty != null)
                            {
                                float deviceDpi = (float)(int)dpiProperty.GetValue(this);
                                dpiX = deviceDpi;
                                dpiY = deviceDpi;
                            }
                            else
                            {
                                IntPtr hdc = GetDC(this.Handle);
                                if (hdc != IntPtr.Zero)
                                {
                                    dpiX = GetDeviceCaps(hdc, LOGPIXELSX);
                                    dpiY = GetDeviceCaps(hdc, LOGPIXELSY);
                                    ReleaseDC(this.Handle, hdc);
                                }
                                else
                                {
                                    dpiX = graphics.DpiX;
                                    dpiY = graphics.DpiY;
                                }
                            }
                        }
                    }
                    catch
                    {
                        dpiX = graphics.DpiX;
                        dpiY = graphics.DpiY;
                    }
#endif
                        float scaleX = dpiX / 96F;
                        float scaleY = dpiY / 96F;

                        int calculateWidth = (int)Math.Ceiling(wpfApplication.DesiredSize.Width * scaleX);
                        int calculateHeight = (int)Math.Ceiling(wpfApplication.DesiredSize.Height * scaleY) + 10;

                        wpfHost.Size = new System.Drawing.Size(calculateWidth, calculateHeight);
                        wpfHost.MinimumSize = new System.Drawing.Size(calculateWidth, calculateHeight);
                        wpfHost.MaximumSize = new System.Drawing.Size(calculateWidth, calculateHeight);
                    }
                }
                finally
                {
                    isUpdating = false;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (isUpdating) return;

            sfaiAssistView1.SuspendLayout();

            foreach(var kvp in botControlMapping)
            {
                UpdateHostControlSize(kvp.Key, kvp.Value);
            }

            sfaiAssistView1.ResumeLayout(true);
        }

        private void OnSuggestionSelected(object sender, SuggestionSelectedEventArgs e)
        {
            if (e.Item is string plainString)
            {
                viewModel.SendUserMessage(plainString);
            }
        }

        private void SfaiAssistView1_StopResponding(object sender, EventArgs e)
        {
            viewModel.CancelAIRequest();
        }

        private void BannerTemplate()
        {
            BannerStyle customStyle = new BannerStyle
            {
                TitleFont = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                SubTitleFont = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular),
                ImageSize = AvatarSize.ExtraLarge,
            };

            string title = "AI Assist ";
            string subTitle = "Your best AI Companion";
            bannerImage = Image.FromFile(@"Asset\AI_Assist.png");
            sfaiAssistView1.SetBannerView(title, subTitle, bannerImage, customStyle);
        }

        private void SfaiAssistView1_ResponseToolBarItemClicked(object sender, ResponseToolBarItemClickedEventArgs e)
        {
            if (e.ToolBarItem.ItemType == ResponseToolBarItemType.Regenerate)
            {
                var messages = viewModel.Chats.OfType<TextMessage>().ToList();
                var lastUserMessage = messages.LastOrDefault(m => m.Author.Name != "Bot");
                
                if (lastUserMessage != null)
                {
                    viewModel.SendUserMessage(lastUserMessage.Text);
                }
            }
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ShowTypingIndicator")
            {
                sfaiAssistView1.ShowTypingIndicator = viewModel.ShowTypingIndicator;
            }
        }
    }
}

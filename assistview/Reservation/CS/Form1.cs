using Syncfusion.WinForms.AIAssistView;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistViewDemo
{
#if NETCOREAPP
    [SupportedOSPlatform("windows")]
#endif
    public partial class Form1 : Form
    {
        ViewModel viewModel = new ViewModel();
        public Form1()
        {
            InitializeComponent();
            sfaiAssistView1.DataBindings.Add("Messages", viewModel, "Chats", true, DataSourceUpdateMode.OnPropertyChanged);
            sfaiAssistView1.DataBindings.Add("ShowTypingIndicator", viewModel, "ShowTypingIndicator", true, DataSourceUpdateMode.OnPropertyChanged);
            sfaiAssistView1.DataBindings.Add("Suggestions", viewModel, "Suggestion", true, DataSourceUpdateMode.OnPropertyChanged);

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
            sfaiAssistView1.StopRespondingButtonClicked += SfaiAssistView1_StopResponding;

            BannerTemplate();
            sfaiAssistView1.TypingIndicator.Author = new Author() { Name = "Bot", AvatarImage = Image.FromFile(@"Asset\AI_Assist.png") };
            sfaiAssistView1.TypingIndicator.DisplayText = "Typing";

            sfaiAssistView1.SuggestionSelected += OnSuggestionSelected;
            viewModel.Chats.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    UpdateButtonState();
                }
            };

            CustomResponseToolbar();
        }

        private void CustomResponseToolbar()
        {
            var toolBarItem = new ResponseToolBarItem
            {
                ItemType = ResponseToolBarItemType.Copy,
                ToolTip = "Clipboard"
            };
            sfaiAssistView1.ResponseToolBarItems.Add(toolBarItem);
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

        private void BannerTemplate()
        {
            BannerStyle customStyle = new BannerStyle
            {
                TitleFont = new Font("Segoe UI", 14F, FontStyle.Bold),
                SubTitleFont = new Font("Segoe UI", 12F, FontStyle.Regular),
                ImageSize = Syncfusion.WinForms.AIAssistView.AvatarSize.Medium,
            };

            string title = "AI Assist ";
            string subTitle = "Your Travel Assistant";
            Image image = Image.FromFile(@"Asset\AI_Assist.png");
            sfaiAssistView1.SetBannerView(title, subTitle, image, customStyle);
        }

        private void OnSuggestionSelected(object sender, SuggestionSelectedEventArgs e)
        {
            if (e.Item is ReservationSuggestion suggestion)
            {
                if (suggestion.Action == SuggestionAction.ShowDatePicker)
                {
                    viewModel.AddInteractivelaceholder("Please Select a Date...");
                    var message = viewModel.Chats[viewModel.Chats.Count - 1] as TextMessage;

                    DateTimePicker dateTime = new DateTimePicker
                    {
                        Format = DateTimePickerFormat.Short,
                        Dock = DockStyle.None,
                    };

                    dateTime.CloseUp += (s, ev) =>
                    {
                        string result = dateTime.Value.ToShortDateString();
                        sfaiAssistView1.SetUserView(message, null);
                        viewModel.Chats.Remove(message);
                        viewModel.SendUserMessage(result);
                    };
                    sfaiAssistView1.SetUserView(message, dateTime);
                }
                else if (suggestion.Action == SuggestionAction.ShowNumberPicker)
                {
                    viewModel.AddInteractivelaceholder("Select number of days...");
                    var message = viewModel.Chats[viewModel.Chats.Count - 1] as TextMessage;

                    NumericUpDown dayPicker = new NumericUpDown
                    {
                        Minimum = 1,
                        Maximum = 30,
                        Width = 100,
                        Dock = DockStyle.None,
                    };

                    dayPicker.KeyDown += (s, ev) => {
                        if (ev.KeyCode == Keys.Enter)
                        {
                            string result = dayPicker.Value.ToString();
                            sfaiAssistView1.SetUserView(message, null);
                            viewModel.Chats.Remove(message);
                            viewModel.SendUserMessage(result);
                        }
                    };

                    sfaiAssistView1.SetUserView(message, dayPicker);
                    this.BeginInvoke(new MethodInvoker(() => dayPicker.Focus()));
                }
                else if (suggestion.Action == SuggestionAction.ShowComboSelector)
                {
                    // show a combo box populated with airline names when the suggestion is the airline selector; otherwise
                    // show airline names, class names, or country names depending on the suggestion label.
                    var display = suggestion.DisplayText ?? string.Empty;
                    var isAirline = display.IndexOf("airline", StringComparison.InvariantCultureIgnoreCase) >= 0;
                    var isClass = display.IndexOf("class", StringComparison.InvariantCultureIgnoreCase) >= 0;

                    viewModel.AddInteractivelaceholder(isAirline ? "Please choose an airline..." : "Please choose a country...");
                    var message = viewModel.Chats[viewModel.Chats.Count - 1] as TextMessage;

                    ComboBox combo = new ComboBox
                    {
                        Dock = DockStyle.None,
                        Width = 200,
                        DropDownStyle = ComboBoxStyle.DropDownList,
                            DataSource = isAirline
                                ? Enum.GetNames(typeof(Airline)).ToList()
                                : isClass
                                    ? Enum.GetNames(typeof(Class)).ToList()
                                    : ResponseManager.Instance.Countries.Select(c => c.Name).ToList()
                    };

                    combo.SelectionChangeCommitted += (s, ev) =>
                    {
                        if (combo.SelectedItem != null)
                        {
                            string selected = combo.SelectedItem.ToString();
                            sfaiAssistView1.SetUserView(message, null);
                            viewModel.Chats.Remove(message);
                            // Send the exact selected string so TrySetValue can match the enum
                            viewModel.SendUserMessage(selected);
                        }
                    };

                    sfaiAssistView1.SetUserView(message, combo);
                    this.BeginInvoke(new MethodInvoker(() => combo.DroppedDown = true));
                }
                else
                {
                    viewModel.SendUserMessage(suggestion.DisplayText);
                }
            }
            else if (e.Item is string plainString)
            {
                viewModel.SendUserMessage(plainString);
            }
        }

        private void SfaiAssistView1_StopResponding(object sender, EventArgs e)
        {
            viewModel.CancelAIRequest();
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

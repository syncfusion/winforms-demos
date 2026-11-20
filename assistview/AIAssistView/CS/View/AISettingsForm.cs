using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISettingsWindow
{
    public partial class AISettingsForm : Form
    {
        private DemoBrowserViewModel viewModel;

        public AISettingsForm()
        {
            InitializeComponent();
        }

        public AISettingsForm(DemoBrowserViewModel demoBrowserViewModel) : this()
        {
            this.viewModel = demoBrowserViewModel ?? new DemoBrowserViewModel();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            txtEndPoint.DataBindings.Add("Text", viewModel, nameof(viewModel.EndPoint), false, DataSourceUpdateMode.OnPropertyChanged);
            txtModelName.DataBindings.Add("Text", viewModel, nameof(viewModel.ModelName), false, DataSourceUpdateMode.OnPropertyChanged);
            txtKey.DataBindings.Add("Text", viewModel, nameof(viewModel.Key), false, DataSourceUpdateMode.OnPropertyChanged);

            // Keep UI in sync when IsAISettingsWindowBusy changes
            viewModel.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(viewModel.IsAISettingsWindowBusy))
                {
                    progressBar.InvokeIfRequired(() => progressBar.Visible = viewModel.IsAISettingsWindowBusy);
                    btnSubmit.InvokeIfRequired(() => btnSubmit.Enabled = !viewModel.IsAISettingsWindowBusy);
                    btnCancel.InvokeIfRequired(() => btnCancel.Enabled = !viewModel.IsAISettingsWindowBusy);
                }
            };
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (viewModel == null) return;

            try
            {
                // Copy view model values into AISettings for validation
                AISettings.EndPoint = viewModel.EndPoint;
                AISettings.ModelName = viewModel.ModelName;
                AISettings.Key = viewModel.Key;

                viewModel.IsAISettingsWindowBusy = true;
                progressBar.Style = ProgressBarStyle.Marquee;

                await AISettings.ValidateCredentials();

                viewModel.IsAISettingsWindowBusy = false;
                progressBar.Style = ProgressBarStyle.Blocks;

                if (string.IsNullOrEmpty(AISettings.ErrorMessage))
                {
                    MessageBox.Show("Successfully entered valid input.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update view model from AISettings (mirrors WPF Closed handler)
                    viewModel.ModelName = AISettings.ModelName;
                    viewModel.Key = AISettings.Key;
                    viewModel.EndPoint = AISettings.EndPoint;

                    // Invoke the click action if provided
                    viewModel.ClickAction?.Invoke("Submit");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(AISettings.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                viewModel.IsAISettingsWindowBusy = false;
                progressBar.Style = ProgressBarStyle.Blocks;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    internal static class ControlExtensions
    {
        public static void InvokeIfRequired(this Control c, Action action)
        {
            if (c.IsHandleCreated && c.InvokeRequired)
                c.Invoke(action);
            else
                action();
        }
    }
}

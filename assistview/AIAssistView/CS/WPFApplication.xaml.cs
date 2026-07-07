using System.Windows;
using System.Windows.Controls;

namespace AssistViewDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WPFApplication : UserControl
    {
        public WPFApplication()
        {
            InitializeComponent();
        }

        public Syncfusion.UI.Xaml.Markdown.SfMarkdownViewer Viewer => this.MarkdownViewer;

        public string MarkDownText
        {
            get => MarkdownViewer.Source;
            set
            {
                MarkdownViewer.Source = value;
                MarkdownViewer.UpdateLayout();
            }
        }
    }
}
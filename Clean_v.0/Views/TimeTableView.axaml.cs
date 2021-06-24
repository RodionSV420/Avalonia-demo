using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModernFlatAvaloniaUI.Views
{
    public partial class TimeTableView : UserControl
    {
        public TimeTableView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
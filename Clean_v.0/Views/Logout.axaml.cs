using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModernFlatAvaloniaUI.Views
{
    public partial class LogoutView : UserControl
    {
        public LogoutView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
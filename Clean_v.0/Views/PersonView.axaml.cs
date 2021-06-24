using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModernFlatAvaloniaUI.Views
{
    public partial class PersonView : UserControl
    {
        public PersonView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
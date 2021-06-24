using System.Windows.Input;
using ReactiveUI;

namespace ModernFlatAvaloniaUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _navigationContent = new DashboardViewModel();
        private bool _closeAppTrigger;

        public bool CloseAppTrigger 
        { 
            get => this._closeAppTrigger;
            set => this.RaiseAndSetIfChanged(ref this._closeAppTrigger, value);
        }

        public ICommand DashboardButtonClicked { get; }

        public ICommand HelpButtonClicked { get; }
        public ICommand TimeTableButtonClicked { get; }
        public ICommand PersonButtonClicked { get; }
        public ICommand EKGButtonClicked { get; }
        public ICommand SettingsButtonClicked { get; }
        public ICommand LogoutButtonClicked { get; }

        public ICommand CloseButtonClicked { get; }

        public ViewModelBase NavigationContent 
        { 
            get => this._navigationContent;
            set => this.RaiseAndSetIfChanged(ref this._navigationContent, value);
        }

        public MainWindowViewModel()
        {
            this.DashboardButtonClicked = ReactiveCommand.Create(this.OnDashboardButtonClicked);
            this.HelpButtonClicked = ReactiveCommand.Create(this.OnHelpButtonClicked);
            this.TimeTableButtonClicked = ReactiveCommand.Create(this.OnTimeTableButtonClicked);
            this.PersonButtonClicked = ReactiveCommand.Create(this.OnPersonButtonClicked);
            this.EKGButtonClicked = ReactiveCommand.Create(this.OnEKGButtonClicked);
            this.SettingsButtonClicked = ReactiveCommand.Create(this.OnSettingsButtonClicked);
            this.LogoutButtonClicked = ReactiveCommand.Create(this.OnLogoutButtonClicked);
            this.CloseButtonClicked = ReactiveCommand.Create(this.OnCloseButton);
        }

        private void OnDashboardButtonClicked()
        {
            this.NavigationContent = new DashboardViewModel();
        }

        private void OnHelpButtonClicked()
        {
            this.NavigationContent = new HelpViewModel();
        }

        private void OnTimeTableButtonClicked()
        {
            this.NavigationContent = new TimeTableViewModel();
        }

        private void OnPersonButtonClicked()
        {
            this.NavigationContent = new PersonViewModel();
        }
        private void OnEKGButtonClicked()
        {
            this.NavigationContent = new EKGViewModel();
        }
        private void OnSettingsButtonClicked()
        {
            this.NavigationContent = new SettingsViewModel();
        }
        private void OnLogoutButtonClicked()
        {
            this.NavigationContent = new LogoutViewModel();
        }

        private void OnCloseButton()
        {
            this.CloseAppTrigger =  true;
        }
    }
}

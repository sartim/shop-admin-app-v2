using System.ComponentModel;
using System.Runtime.CompilerServices;
using ShopAdminApp.Services;
using ShopAdmin.Helpers;

namespace ShopAdmin.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private AuthService _authService;
        
        private string _Email;
        private string _Password;

        private bool _IsLoading;
                private bool _isPhoneInvalid;

        public string Email
        {
            get => _Email;
            set
            {
                _Email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }

        public bool IsLoading
        {
            get => _IsLoading;
            set
            {
                _IsLoading = value;
                OnPropertyChanged();
            }
        }
        public Command LoginCommand {get; set;}

        public LoginViewModel()
        {
            _authService = new AuthService();
            LoginCommand = new Command(async () => await Login());
        }


        private async Task Login()
        {
            IsLoading = true;
            bool isAuthenticated = await _authService.Authenticate(Email, Password);
            if (isAuthenticated) {
                Application.Current.MainPage = new NavigationPage(new AppShell());
            } else {
                IsLoading = false;
                string text = "Invalid credentials, Please try again";
                await Alert.ToastAlert(text);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private EventHandler bindingContext;

        public EventHandler BindingContext { get => bindingContext; set => SetProperty(ref bindingContext, value); }
    }
}

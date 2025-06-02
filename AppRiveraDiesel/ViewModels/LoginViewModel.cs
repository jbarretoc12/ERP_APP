using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppRiveraDiesel.Views;

namespace AppRiveraDiesel.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _password;
        private bool _rememberMe;

        public string Email
        {
            get => _email;
            set
            {
                if (_email == value) return;
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password == value) return;
                _password = value;
                OnPropertyChanged();
            }
        }

        public bool RememberMe
        {
            get => _rememberMe;
            set
            {
                if (_rememberMe == value) return;
                _rememberMe = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand SignUpTap { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            SignUpTap = new Command(OnSignUp);
        }

        private async void OnLogin()
        {
            // Aquí puedes validar contra tu API en el futuro
            if (Email == "admin" && Password == "1234")
            {
                //await Shell.Current.DisplayAlert("Bienvenido", "Inicio de sesión correcto", "OK");

                // Navegar a la página principal si deseas:
                // await Shell.Current.GoToAsync("//MainPage");

                await Shell.Current.GoToAsync("HomePage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }

        private async void OnSignUp()
        {
            /*await Shell.Current.DisplayAlert("Registro", "Redirigiendo a la pantalla de registro", "OK");*/
            Console.WriteLine("===> Entró a REGISTRARSEEEEEEEEEEEEEEE");
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

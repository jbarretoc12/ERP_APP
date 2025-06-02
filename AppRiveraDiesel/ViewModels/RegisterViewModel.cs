using AppRiveraDiesel.Models;
using AppRiveraDiesel.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AppRiveraDiesel.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _fullName;
        private string _email;
        private string _password;
        private string _confirmPassword;

        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set { _confirmPassword = value; OnPropertyChanged(); }
        }

        public ICommand RegisterCommand { get; }
        public ICommand GoToLoginCommand { get; }

        public RegisterViewModel()
        {
            Console.WriteLine("===> Se creó RegisterViewModel");
            RegisterCommand = new Command(OnRegister);
            GoToLoginCommand = new Command(OnGoToLogin);
        }

        private async void OnRegister()
        {
            //if (string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Email) ||
            //    string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword))
            //{
            //    await Shell.Current.DisplayAlert("Error", "Por favor completa todos los campos", "OK");
            //    return;
            //}

            //if (Password != ConfirmPassword)
            //{
            //    await Shell.Current.DisplayAlert("Error", "Las contraseñas no coinciden", "OK");
            //    return;
            //}

            //// Aquí podrías enviar los datos a tu API para registrar
            //await Shell.Current.DisplayAlert("Registrado", "Cuenta creada correctamente", "OK");
            //await Shell.Current.GoToAsync("//LoginPage");

            var api = new ApiService();
            var request = new RegistroRequest
            {
                NombreCompleto = FullName,
                Correo = Email,
                Contrasena = Password,
                ConfirmarContrasena = ConfirmPassword
            };

            bool result = await api.RegistrarUsuarioAsync(request);
            await Shell.Current.DisplayAlert("Registrado", "Cuenta creada correctamente", "OK");
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void OnGoToLogin()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

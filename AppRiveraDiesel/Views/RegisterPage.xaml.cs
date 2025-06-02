using AppRiveraDiesel.ViewModels;
namespace AppRiveraDiesel.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}
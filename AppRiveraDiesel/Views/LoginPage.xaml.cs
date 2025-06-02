using AppRiveraDiesel.ViewModels;
namespace AppRiveraDiesel.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}
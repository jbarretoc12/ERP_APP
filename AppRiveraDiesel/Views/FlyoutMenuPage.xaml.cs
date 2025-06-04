namespace MenuPrincipal.Views;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
	}
    private  void OnPage1Clicked(object sender, EventArgs e)
    {
        //((MainPage)Application.Current.MainPage).NavigateTo(new ProyectosPage());
        //await Navigation.PushAsync(new ProyectosPage());
    }

    private  void OnPage2Clicked(object sender, EventArgs e)
    {
       // ((MainPage)Application.Current.MainPage).NavigateTo(new TareosPage());
        //await Navigation.PushAsync(new TareosPage());
    }
}
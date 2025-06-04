using AppRiveraDiesel.Views;

namespace AppRiveraDiesel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

        }
    }
}

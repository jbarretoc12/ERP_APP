﻿namespace AppRiveraDiesel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new NavigationPage(new Views.LoginPage());
            MainPage = new AppShell(); // ¡Esto es crítico!
        }
    }
}

using System;
using FreshMvvm;
using FreshMvvmTabbedNavigation.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FreshMvvmTabbedNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var mainPage = new FreshTabbedNavigationContainer();
            mainPage.AddTab<FirstPageModel>("First", null);
            mainPage.AddTab<SecondPageModel>("Second", null);
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

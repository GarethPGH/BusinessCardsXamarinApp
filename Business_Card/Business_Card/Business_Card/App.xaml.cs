using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Business_Card.Model;
using Business_Card.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Business_Card
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage();
        }

        protected override void OnStart()
        {
            var NewBusinessCardPage = new BusinessCardViewModel();
         
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

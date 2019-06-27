﻿using System;
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

            MainPage = new MainPage();
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

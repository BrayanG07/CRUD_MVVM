﻿using CRUD_MVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AgregarAlumnoView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

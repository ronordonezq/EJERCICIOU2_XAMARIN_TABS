﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIOU2_XAMARIN_TABS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyTabbedPage();
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

﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XModules.Core.Abstraction;
using XModules.Core.Managers;

namespace ModularApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IModuleManager, ModuleManager>();

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

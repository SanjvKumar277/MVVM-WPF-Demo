﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Sanjiv.WPF.Interfaces;
using Sanjiv.WPF.Services;
using Sanjiv.WPF.ViewModels;
using Sanjiv.WPF.Views;

namespace Sanjiv.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IPrincipal CurrentPrincipal;

        protected override void OnStartup(StartupEventArgs e)
        {
            //Create a custom principal with an anonymous identity at startup
            CustomPrincipal customPrincipal = new CustomPrincipal();

            CurrentPrincipal = customPrincipal;
            AppDomain.CurrentDomain.SetThreadPrincipal(customPrincipal);
            Thread.CurrentPrincipal = customPrincipal;
            AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.UnauthenticatedPrincipal);

            base.OnStartup(e);

          

        }
    }
}

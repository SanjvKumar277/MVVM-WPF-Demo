﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sanjiv.WPF.Interfaces;
using Sanjiv.WPF.ViewModels;

namespace Sanjiv.WPF.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window, IView
    {
        public LoginWindow(AuthenticationViewModel viewModel)
        {
            viewModel.OnRequestClose += CloseWindow;
            viewModel.OnRequestFocus += RequestFocus;
            ViewModel = viewModel;
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            TxtUsername.Focus();
        }

        #region IView Members
        public IViewModel ViewModel
        {
            get { return DataContext as IViewModel; }
            set { DataContext = value; }
        }
        #endregion

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestFocus(object sender, EventArgs e)
        {
            TxtUsername.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

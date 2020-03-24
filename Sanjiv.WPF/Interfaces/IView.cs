using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Sanjiv.WPF.ViewModels;

namespace Sanjiv.WPF.Interfaces
{
    public interface IView
    {
        IViewModel ViewModel
        {
            get;
            set;
        }

        void Show();

        Window Owner { get; set; }
    }
}

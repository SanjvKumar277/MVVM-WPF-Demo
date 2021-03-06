﻿using System;
using System.Collections.ObjectModel;
using Sanjiv.WPF.Interfaces;
using Sanjiv.Common.Models;
using Sanjiv.WPF.Services;

namespace Sanjiv.WPF.ViewModels
{
    public class AdminWindowViewModel : BaseViewModel
    {
        private readonly IProductService _productService;

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                SetProperty(ref products, value);
            }
        }

        public AdminWindowViewModel()
        {
            _productService = new ProductService();
            LoadData();
        }

        //public AdminWindowViewModel()
        //{
        //    LoadData();
        //}

        private async void LoadData()
        {
            Products = await _productService.GetAllProducts();
            Console.WriteLine($"Products : {Products}");
        }
    }
}

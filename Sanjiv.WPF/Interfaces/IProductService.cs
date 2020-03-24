using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Sanjiv.Common.Models;

namespace Sanjiv.WPF.Interfaces
{
    public interface IProductService
    {
        Task<ObservableCollection<Product>> GetAllProducts();
    }
}

using CrudMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CrudMobileApp.ViewModels
{
    public class ProductBrowserViewModel
    {
        private ObservableCollection<Product> _products { get; set; }
        public ProductBrowserViewModel(ObservableCollection<Product> products)
        {
            _products = products;
        }

        public ObservableCollection<Product> Products { get { return _products; } }
    }
}

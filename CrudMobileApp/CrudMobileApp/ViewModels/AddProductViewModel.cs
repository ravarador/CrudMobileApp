using CrudMobileApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrudMobileApp.ViewModels
{
    public class AddProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int id = 23112;
        string productName = "Ravni Arador";

        public AddProductViewModel()
        {
            SaveProductCommand = new Command(SaveProduct);

            OpenProductBrowserCommand = new Command(async () => await OpenProductBrowser());
        }
        void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Command OpenProductBrowserCommand { get; }
        public Command SaveProductCommand { get; }

        async Task OpenProductBrowser()
        {
            var productBrowserViewModel = new ProductBrowserViewModel();
            var productBrowser = new ProductBrowser();
            productBrowser.BindingContext = productBrowserViewModel;

            await Application.Current.MainPage.Navigation.PushAsync(productBrowser);
        }

        void SaveProduct()
        {

        }

        public string ProductName
        {
            get { return productName; }
            set 
            { 
                productName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public int Id
        {
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public string DisplayMessage
        {
            get { return $"{Id} : {ProductName}"; }
        }

    }
}

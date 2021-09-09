using CrudMobileApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CrudMobileApp.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            AddCommand = new Command(Add);
        }

        FirebaseHelper firebaseHelper = new FirebaseHelper();

        string id = "";
        string personName = "";

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string Name
        {
            get { return personName; }
            set
            {
                personName = value;
                OnPropertyChanged();
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public Command AddCommand { get; }
        public async void Add()
        {
            await firebaseHelper.AddPerson(Convert.ToInt32(Id), Name);
            Id = string.Empty;
            Name = string.Empty;
            //await DisplayAlert("Success", "Person Added Successfully", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }

        void UpdateCommand()
        {

        }

        void DeleteCommand()
        {

        }
    }
}

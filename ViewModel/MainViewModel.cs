using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


namespace Csharp_Academy.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity _connectivity)
        {
            Items = new ObservableCollection<string>();
            this.connectivity = _connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async void Add() {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No Internet...","  Will attempt again once connected","OK");
                return; 
            }

            // Add the item
            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s) {
            if (Items.Contains(s)) Items.Remove(s);
        }

        /* Navigation */ 

        [RelayCommand]
        async Task Tap(string s)
        {
            // Dev decision on what we pass in here to GoToAsync
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }

        
        /* Removed this code to use the MVVM Nuget Community Package */
        // >>>> Removed all this for the [ObservalbeProperty] attribute <<<<

        //public string Text{
        //    get => text;
        //    set
        //    {
        //        text = value;
        //        OnPropertyChanged(nameof(Text));

        //    }
        //}      
        
        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name) => PropertyChanged.Invoke(this,new PropertyChangedEventArgs(name)); 


    }
}

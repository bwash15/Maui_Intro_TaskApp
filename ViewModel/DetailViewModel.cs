using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Csharp_Academy.ViewModel;
namespace Csharp_Academy;

[QueryProperty("Text","Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack()
    {
        // if to navigate to another page here is where it could be done
        // replace the (..) with [/nameofthepage]
        await Shell.Current.GoToAsync("..");
    }
}


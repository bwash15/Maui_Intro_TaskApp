using Csharp_Academy.ViewModel;

namespace Csharp_Academy;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}


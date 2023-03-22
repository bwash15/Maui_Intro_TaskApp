using Csharp_Academy.ViewModel;

namespace Csharp_Academy;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
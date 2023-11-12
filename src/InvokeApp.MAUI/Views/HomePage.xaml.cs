using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel homeViewModel)
	{
	    BindingContext = homeViewModel;

		InitializeComponent();
	}
}
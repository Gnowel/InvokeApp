using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel homeViewModel)
	{
	    BindingContext = homeViewModel;

		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
		await (BindingContext as HomeViewModel)?.Initialize();
        base.OnAppearing();
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}
}
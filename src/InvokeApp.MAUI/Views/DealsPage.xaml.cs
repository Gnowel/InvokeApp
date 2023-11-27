using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class DealsPage : ContentPage
{
	public DealsPage(DealsViewModel dealsViewModel)
	{
		BindingContext = dealsViewModel;

		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        await (BindingContext as DealsViewModel)?.Initialize();
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}
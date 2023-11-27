using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class FavoritePage : ContentPage
{
	public FavoritePage(FavoriteViewModel favoriteViewModel)
	{
		BindingContext = favoriteViewModel;
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        await (BindingContext as FavoriteViewModel)?.Initialize();
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}
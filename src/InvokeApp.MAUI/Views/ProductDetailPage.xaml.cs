using InvokeApp.MAUI.ViewModels;

namespace InvokeApp.MAUI.Views;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductDetailViewModel productDetailViewModel)
	{
        BindingContext = productDetailViewModel;
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        await (BindingContext as ProductDetailViewModel)?.Initialize();
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}
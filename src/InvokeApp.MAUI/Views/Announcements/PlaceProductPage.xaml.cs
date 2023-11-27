using InvokeApp.MAUI.ViewModels.Announcements;

namespace InvokeApp.MAUI.Views.Announcements;

public partial class PlaceProductPage : ContentPage
{
	public PlaceProductPage(PlaceProductViewModel placeProductViewModel)
	{
		BindingContext = placeProductViewModel;
		InitializeComponent();
	}
}
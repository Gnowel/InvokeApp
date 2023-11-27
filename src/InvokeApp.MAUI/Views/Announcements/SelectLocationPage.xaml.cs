using InvokeApp.MAUI.ViewModels.Announcements;

namespace InvokeApp.MAUI.Views.Announcements;

public partial class SelectLocationPage : ContentPage
{
	public SelectLocationPage(SelectLocationViewModel selectLocationViewModel)
	{
		BindingContext = selectLocationViewModel;
		InitializeComponent();
	}
}
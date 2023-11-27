using InvokeApp.MAUI.ViewModels.Announcements;

namespace InvokeApp.MAUI.Views.Announcements;

public partial class DescriptionProductPage : ContentPage
{
	public DescriptionProductPage(DescriptionProductViewModel descriptionProductViewModel)
	{
		BindingContext = descriptionProductViewModel;
		InitializeComponent();
	}
}
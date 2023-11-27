using InvokeApp.MAUI.ViewModels.Announcements;

namespace InvokeApp.MAUI.Views.Announcements;

public partial class SpecifyPricePage : ContentPage
{
	public SpecifyPricePage(SpecifyPriceViewModel specifyPriceViewModel)
	{
		BindingContext = specifyPriceViewModel; 
		InitializeComponent();
	}
}
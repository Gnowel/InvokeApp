using CommunityToolkit.Maui.Views;
using InvokeApp.MAUI.ViewModels.Popups;

namespace InvokeApp.MAUI.Views.Popups;

public partial class PricePopup : Popup
{
	public PricePopup(PriceViewModel costViewModel)
	{
		BindingContext = costViewModel; 

		InitializeComponent();
	}
}
using CommunityToolkit.Maui.Views;
using InvokeApp.MAUI.ViewModels.Popups;

namespace InvokeApp.MAUI.Views.Popups;


public partial class SortingPopup : Popup
{
	public SortingPopup(SortingViewModel sortingViewModel)
	{
		BindingContext = sortingViewModel;

		InitializeComponent();
	}
}
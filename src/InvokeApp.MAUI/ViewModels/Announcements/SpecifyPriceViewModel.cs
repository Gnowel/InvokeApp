using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels.Announcements
{
    public partial class SpecifyPriceViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _price;
        public SpecifyPriceViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [RelayCommand]
        private void SelectLocationAsync() =>
                NavigationService.NavigateToAsync("SelectLocation");

        [RelayCommand]
        private void BackAsync() => NavigationService.PopAsync();
    }
}

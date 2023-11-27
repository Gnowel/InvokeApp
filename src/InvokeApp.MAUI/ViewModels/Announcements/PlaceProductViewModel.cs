using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels.Announcements
{
    public partial class PlaceProductViewModel : BaseViewModel
    {
        public PlaceProductViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [RelayCommand]
        private void DescriptionProductAsync() =>
            NavigationService.NavigateToAsync("DescriptionProduct");
        [RelayCommand]
        private void BackAsync() => 
            NavigationService.PopAsync();
    }
}

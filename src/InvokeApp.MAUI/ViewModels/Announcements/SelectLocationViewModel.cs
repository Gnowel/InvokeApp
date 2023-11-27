using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels.Announcements
{
    public partial class SelectLocationViewModel : BaseViewModel
    {
        public SelectLocationViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [RelayCommand]
        private void BackAsync() => NavigationService.PopAsync();
    }
}

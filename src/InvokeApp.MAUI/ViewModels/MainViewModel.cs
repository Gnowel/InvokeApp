using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        [RelayCommand]
        public void LoginAsync() => NavigationService.NavigateToAsync("Login");

        [RelayCommand]
        public void RegisterAsync() => NavigationService.NavigateToAsync("Register");

    }
}

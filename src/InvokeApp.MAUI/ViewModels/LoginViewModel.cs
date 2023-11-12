using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;
using System.Diagnostics;


namespace InvokeApp.MAUI.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _password;
        [ObservableProperty]
        private bool _isHidePassword = true;
        [ObservableProperty]
        private string _hideText = "Показать";
        public LoginViewModel(INavigationService navigationService): base(navigationService)
        {
        }

        [RelayCommand]
        private void HidePassword()
        {
            IsHidePassword = !IsHidePassword;
            HideText = IsHidePassword == true ? "Показать" : "Cкрыть";
            
            Debug.WriteLine($"isHidePassword = {IsHidePassword}, hideText = {HideText}");
        }

        [RelayCommand]
        private void MainAsync() => NavigationService.PopAsync();
        
        [RelayCommand]
        private void RegisterAsync() => NavigationService.NavigateToAsync("Register");
        [RelayCommand]
        private void HomeAsync() => NavigationService.NavigateToAsync("//Main/Home");
    }
}

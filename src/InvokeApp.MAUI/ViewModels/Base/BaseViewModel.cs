
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using InvokeApp.MAUI.Services.Navigation;

namespace InvokeApp.MAUI.ViewModels.Base
{
    public class BaseViewModel : ObservableObject
    {
        public INavigationService NavigationService { get; }

        public BaseViewModel(INavigationService navigationService) 
        {
            NavigationService = navigationService;
        }

    }
}

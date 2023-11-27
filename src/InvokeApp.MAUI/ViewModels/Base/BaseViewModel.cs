using CommunityToolkit.Mvvm.ComponentModel;
using InvokeApp.MAUI.Services.Navigation;

namespace InvokeApp.MAUI.ViewModels.Base
{
    public abstract class BaseViewModel : ObservableObject
    {
        public INavigationService NavigationService { get; }

        public BaseViewModel(INavigationService navigationService) 
        {
            NavigationService = navigationService;
        }

    }
}

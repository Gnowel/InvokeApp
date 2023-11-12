using CommunityToolkit.Mvvm.ComponentModel;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _filterName = "Самые новые";

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels.Announcements
{
    public partial class DescriptionProductViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string[] _category = { "Одежда & обувь", "Мебель", "Машина & грузовики" };

        [ObservableProperty]
        private string _selectedCategory = "Выберите категорию";

        [ObservableProperty]
        private int _sliderValue = 3;
        public DescriptionProductViewModel(INavigationService navigationService) : base(navigationService){}
        
        [RelayCommand]
        private void SpecifyPriceAsync() =>
                NavigationService.NavigateToAsync("SpecifyPrice");

        [RelayCommand]
        private void BackAsync() => NavigationService.PopAsync();
    }
}

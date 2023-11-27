using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.PopupNavigation;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.ViewModels.Popups
{
    public partial class PriceViewModel : BasePopupViewModel
    {
        [ObservableProperty]
        private string _minPrice;
        [ObservableProperty]
        private string _maxPrice;
        public PriceViewModel(IPopupService popupService) : base(popupService)
        {
        }

        [RelayCommand]
        private void Close()
        {
            int minPrice = int.Parse(MinPrice);
            int maxPrice = int.Parse(MaxPrice);

            if(minPrice < maxPrice)
            {
                PopupService.HidePopup(new Tuple<int,int>(minPrice, maxPrice));
            }
        }
    }
}

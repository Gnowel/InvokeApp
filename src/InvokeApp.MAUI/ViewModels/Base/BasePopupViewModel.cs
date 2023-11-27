using CommunityToolkit.Mvvm.ComponentModel;
using InvokeApp.MAUI.Services.PopupNavigation;

namespace InvokeApp.MAUI.ViewModels.Base
{
    public abstract class BasePopupViewModel : ObservableObject
    {
        public IPopupService PopupService { get; }

        public BasePopupViewModel(IPopupService popupService)
        {
            PopupService = popupService;
        }
    }
}

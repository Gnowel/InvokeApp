using CommunityToolkit.Maui.Views;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.Services.PopupNavigation
{
    public interface IPopupService
    {
        Task<object> ShowPopupAsync<T, V>(Action<V> viewModelSetup = null, View anchor = null) where T : Popup where V : BasePopupViewModel;
        void HidePopup(object result);
    }
}

using CommunityToolkit.Maui.Views;
using InvokeApp.MAUI.ViewModels.Base;

namespace InvokeApp.MAUI.Services.PopupNavigation
{
    class PopupService : IPopupService
    {
        private readonly IServiceProvider _serviceProvider;
        private Stack<Popup> popups = new();


        public PopupService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<object> ShowPopupAsync<T, V>(Action<V> viewModelSetup = null, View anchor = null)
            where T : Popup
            where V : BasePopupViewModel
        {
            var popup = _serviceProvider.GetRequiredService<T>();
            var viewModel = _serviceProvider.GetRequiredService<V>();
            viewModelSetup?.Invoke(viewModel);
            popup.BindingContext = viewModel;
            
            if(anchor is not null)
            {
                popup.Anchor = anchor;
            }

            popups.Push(popup);


            return Application.Current.MainPage.ShowPopupAsync(popup);
        }

        public async void HidePopup(object result)
        {
            if(popups.Count > 0)
            {
                await popups.Pop().CloseAsync(result);
            }
        }
    }
}

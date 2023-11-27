using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.PopupNavigation;
using InvokeApp.MAUI.ViewModels.Base;
using InvokeApp.Shared.Enums;
using System.Diagnostics;

namespace InvokeApp.MAUI.ViewModels.Popups
{
    public partial class SortingViewModel : BasePopupViewModel
    {
        public List<Sorting> FilterNames { get; }

        [ObservableProperty]
        private Sorting _selectedSorting;

        public SortingViewModel(IPopupService popupService) 
            : base(popupService) 
        {
            FilterNames = new List<Sorting>()
            {
                Sorting.New,
                Sorting.Expensive,
                Sorting.Cheap
            };
        }

        [RelayCommand]
        private void Close()
        {
            PopupService.HidePopup(SelectedSorting);
        } 
    }
}

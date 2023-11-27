using CommunityToolkit.Mvvm.ComponentModel;
using InvokeApp.Shared.Enums;

namespace InvokeApp.MAUI.Models
{
    public partial class FilterModel : ObservableObject
    {
        [ObservableProperty]
        private int _minCost;
        [ObservableProperty]
        private int _maxCost;
        [ObservableProperty]
        private int _category;
        [ObservableProperty]
        private Sorting _sorting = Sorting.New;
    }
}

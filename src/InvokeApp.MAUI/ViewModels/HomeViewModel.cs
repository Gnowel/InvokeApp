using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Models;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Services.PopupNavigation;
using InvokeApp.MAUI.Services.Product;
using InvokeApp.MAUI.ViewModels.Base;
using InvokeApp.MAUI.ViewModels.Popups;
using InvokeApp.MAUI.Views.Popups;
using InvokeApp.Shared.DTOs.Products;
using InvokeApp.Shared.Enums;
using System.Collections.ObjectModel;

namespace InvokeApp.MAUI.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        private readonly IPopupService _popupService;
        private readonly IProductService _productService;

        [ObservableProperty]
        private FilterModel _filter = new();

        [ObservableProperty]
        private string _price = "Цена: любая";

        public ObservableCollection<ProductDto> Products { get; set; } = new();

        public HomeViewModel(
            IProductService productService,
            INavigationService navigationService,
            IPopupService popupService) : base(navigationService)
        {
            _productService = productService;
            _popupService = popupService;
        }

        public async Task Initialize()
        {
            var products  = _productService.GetProducts();
            Products.Clear();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

        [RelayCommand]
        private async void DisplaySortingPopup(View anchor)
        {
            var result = await _popupService.ShowPopupAsync<SortingPopup, SortingViewModel>(model =>
            {
                model.SelectedSorting = Filter.Sorting;
            }, anchor: anchor);

            if (result is Sorting nameSorting)
            {
                Filter.Sorting = nameSorting;
            }
        }

        [RelayCommand]
        private async void DisplayCostPopup(View anchor)
        {
            var result = await _popupService.ShowPopupAsync<PricePopup, PriceViewModel>(anchor: anchor);

            if(result is Tuple<int, int> cost)
            {
                Filter.MinCost = cost.Item1;
                Filter.MaxCost = cost.Item2;

                if (Filter.MinCost == 0 || Filter.MaxCost == 0)
                {
                    Price = "Цена: любая";
                }
                else
                {
                    Price = $"Цена: {Filter.MinCost} до {Filter.MaxCost}";
                }
            }
        }
        [RelayCommand]
        private async void ProductDetailAsync(ProductDto product)
        {
            if(product == null)
            {
                return;
            }

            await NavigationService.NavigateToAsync(
                "ProductDetail",
                new Dictionary<string, object> { { "ProductId", product.Id } });
        }
    }
}

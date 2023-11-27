using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Deal;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Services.Product;
using InvokeApp.MAUI.ViewModels.Base;
using InvokeApp.Shared.DTOs.Deals;
using InvokeApp.Shared.DTOs.Products;
using System.Collections.ObjectModel;

namespace InvokeApp.MAUI.ViewModels
{
    public partial class DealsViewModel : BaseViewModel
    {
        private readonly IProductService _productService;
        private readonly IDealService _dealService;

        [ObservableProperty]
        private bool isSale = true;
        [ObservableProperty]
        private bool isPurchases = false;

        public ObservableCollection<ProductSellingDto> SellingProducts { get; set; } = new();
        public ObservableCollection<BuyingDealDto> BuyingProducts { get; set; } = new();

        public DealsViewModel(
            INavigationService navigationService,
            IProductService productService,
            IDealService dealService) : base(navigationService)
        {
            _productService = productService;
            _dealService = dealService;
        }

        public async Task Initialize()
        {
            var sellingProducts = _productService.GetProductSelling();
            var buyingProducts = _dealService.GetDeals();   

            SellingProducts.Clear();
            foreach (var product in sellingProducts)
            {
                SellingProducts.Add(product);
            }

            BuyingProducts.Clear();
            foreach (var product in buyingProducts)
            {
                BuyingProducts.Add(product);
            }
        }


        [RelayCommand]
        private void SelectItem()
        {
            IsSale = !IsSale;
            IsPurchases = !IsPurchases;
        }

    }
}

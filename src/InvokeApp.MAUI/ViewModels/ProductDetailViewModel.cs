using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Services.Product;
using InvokeApp.MAUI.ViewModels.Base;
using InvokeApp.Shared.DTOs.Products;

namespace InvokeApp.MAUI.ViewModels
{
    [QueryProperty(nameof(ProductId), nameof(ProductId))]
    public partial class ProductDetailViewModel : BaseViewModel
    {
        private readonly IProductService _productService;

        [ObservableProperty]
        private ProductDetailDto _productDetail;

        [ObservableProperty]
        private string favoriteImage = "favorite_disenabled.svg";

        [ObservableProperty]
        private Guid productId;

        [ObservableProperty]
        private string _productInformation;

        [ObservableProperty]
        private int _maxLines = 4;

        [ObservableProperty]
        private string _readMoreText = "Подробнее";
        public ProductDetailViewModel(
            INavigationService navigationService,
            IProductService productService) : base(navigationService)
        {
            _productService = productService;
        }

        public async Task Initialize()
        {
            ProductDetail = _productService.GetProduct(ProductId);
            ProductInformation = $"{ProductDetail.Category}, {ProductDetail.Condition}";
        }

        [RelayCommand]
        private void Favorite()
        {
            FavoriteImage = FavoriteImage == "favorite_disenabled.svg" ? "favorite_enabled.svg" : "favorite_disenabled.svg";
        }

        [RelayCommand]
        private void ReadMore()
        {
            MaxLines = MaxLines == 4 ? 100 : 4;
            ReadMoreText = ReadMoreText == "Подробнее" ? "Скрыть" : "Подробнее";
        }

        [RelayCommand]
        private void BackAsync() => NavigationService.PopAsync();
    }
}

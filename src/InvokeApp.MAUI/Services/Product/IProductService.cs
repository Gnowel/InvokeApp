using InvokeApp.Shared.DTOs.Products;

namespace InvokeApp.MAUI.Services.Product
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductDetailDto GetProduct(Guid id);
        List<ProductSellingDto> GetProductSelling();
    }
}

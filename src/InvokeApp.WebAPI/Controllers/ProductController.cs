using InvokeApp.Infrastructure.Context;
using InvokeApp.Shared.DTOs.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvokeApp.WebAPI.Controllers
{
    /// <summary>
    /// Контроллер для товаров
    /// </summary>
    public class ProductController : Controller
    {
        private readonly InvokeAppDbContext _context;

        public ProductController(InvokeAppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает все вещи, которые сейчас продаются
        /// </summary>
        /// <returns>Список вещей</returns>
        [HttpGet]
        [Route("api/products/sale")]
        public async Task<ActionResult<List<ProductDto>>> GetProductSale()
        {
            var products = await _context.Products.Where(x => x.Sold == false)
                .Select(p => new ProductDto
            {
                Id = p.Id,
                ImageUrl = p.ImageUrl,

            }).ToListAsync();

            return Ok(products);
        }

        /// <summary>
        /// Получает детальное описание товара
        /// </summary>
        /// <param name="id">Id товара</param>
        /// <returns>Товар</returns>
        [HttpGet]
        [Route("api/products/{id}")]
        public async Task<ActionResult<ProductDetailDto>> GetProductDetail(int id)
        {
            var product = await _context.Products
                .Include(P => P.Category)
                .Include(p => p.Condition)
                .Include(p => p.Seller)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var productDto = new ProductDetailDto()
            {
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Category = product.Category.Name,
                Condition = product.Condition.Name,
                Description = product.Description,
                Price = product.Price,
                Sold = product.Sold,
                SellerId = product.SellerId,
                SellerName = product.Seller.Name,
                SellerImageUrl = product.Seller.ImageUrl
            };

            return Ok(productDto);
        }

    }
}

using InvokeApp.Shared.DTOs;

namespace InvokeApp.MAUI.Services.Favourite
{
    public class FavouriteService : IFavouriteService
    {
        public List<FavouriteDto> GetFavourites()
        {
            return new List<FavouriteDto>()
            {
                new FavouriteDto()
                {
                    Id = Guid.NewGuid(),
                    ImageUrl = "https://xn--90agckdhfyiqnp.xn--p1ai/wa-data/public/shop/products/20/56/5620/images/35192/photo_2023-02-02_14-26-52.970.jpg",
                    Name = "Lenovo T460 14 (i5-6300U, 8GB, SSD256, Intel HD)",
                    Price = 21000
                },
                new FavouriteDto()
                {
                    Id = Guid.NewGuid(),
                    ImageUrl = "https://room78.net/wp-content/uploads/2023/04/urlmy1jtj8.jpg",
                    Name = "New Balance 9060 Sea Salt (бежевые)",
                    Price = 25200
                }
            };
        }
    }
}

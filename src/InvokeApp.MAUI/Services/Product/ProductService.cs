using InvokeApp.Shared.DTOs.Products;
using System.Diagnostics;
using System.Xml.Linq;

namespace InvokeApp.MAUI.Services.Product
{
    public class ProductService : IProductService
    {
        private List<Guid> _productId;

        public ProductService() 
        {
            _productId = new List<Guid>()
            {
                new Guid("db6ec581-7fd8-4ba1-aa7b-714cc879eed6"),
                new Guid("a9331186-42d9-4494-863d-2cd0594781d3")
            };
        }

        public ProductDetailDto GetProduct(Guid productId)
        {
            if (productId == _productId[0])
            {
                return new ProductDetailDto()
                {
                    ImageUrl = "https://images.journeys.com/images/products/1_268755_ZM_THERO.JPG",
                    Name = "Мужские классические ботинки Timberland",
                    Category = "Одежда & обувь",
                    Condition = "Открытая коробка (никогда не использовалась)",
                    Description = "Размер 9US, черный цвет.Оригинальные ботинки Timberland®, впервые разработанные почти сорок лет назад и ставшие неотъемлемой частью миллионов прихожих и гаражей по всему миру. Эти вневременные модели Timbs изготовлены из водонепроницаемой кожи премиум-класса, имеют герметичную конструкцию и прочную подошву с выступами, что придает этой классике долговечность, позволяющую смело выдерживать любые условия и быть готовыми к следующему приключению.",
                    Price = 22300,
                    Sold = false,
                    SellerId = Guid.NewGuid(),
                    SellerName = "Rick Grimes",
                    SellerImageUrl = "https://avatars.akamai.steamstatic.com/d08bc2f1f09e2e1566df8d93bb3ffeef9e80b5a5_full.jpg"
                };
            }

            Debug.Write(_productId[0]);

            return new ProductDetailDto()
            {
                ImageUrl = "https://pc-1.ru/pic/big/183501.jpg",
                Name = "Ноутбук Toshiba Satellite M40X-116 Intel Pentium M 730 (1.60GHz)",
                Category = "Компьютерная техника",
                Condition = "б/у",
                Description = "Ноутбук Toshiba Satellite M40X-116 (PSM4XE-01K019RU) \nЭкран: 15\" 1280x800 WXGA 16:10 \nПроцессор: Intel Pentium M 730 (1.60GHz) \nОперативная память: DDR 1Gb \nЖесткий диск: IDE 60Gb \nОптический привод: DVD-RW \nВидеокарта: Intel GMA 900 \nИнтерфейсы: Wi-Fi \nРазъемы: SVGA, S-Video, 3x USB 2.0, LAN, Modem, Fire Wire (1394), PCMCIA, CardReader \nОперационная система: Windows XP",
                Price = 4990,
                Sold = false,
                SellerId = Guid.NewGuid(),
                SellerName = "Mister Spock",
                SellerImageUrl = "https://www.imdb.com/title/tt0060028/mediaviewer/rm45491456?ft0=name&fv0=nm0000559&ft1=image_type&fv1=still_frame&ref_=tt_ch"
            };
        }

        public List<ProductDto> GetProducts()
        {
            return new List<ProductDto>()
            {
                new ProductDto(){ImageUrl = "https://images.journeys.com/images/products/1_268755_ZM_THERO.JPG" , Id = _productId[0]},
                new ProductDto(){ImageUrl = "https://pc-1.ru/pic/big/183501.jpg" , Id = _productId[1]}
            };

        }

        public List<ProductSellingDto> GetProductSelling()
        {
            return new List<ProductSellingDto>()
            {
                new ProductSellingDto(){Id = Guid.NewGuid(), ImageUrl = "https://i.ebayimg.com/00/s/MTIwMFgxNjAw/z/CJoAAOSwcCxklLOU/$_57.JPG?set_id=880000500F",Name = "Pioneer XDJ-RR", Price = 37000, Sold = true},
                new ProductSellingDto(){Id = Guid.NewGuid(), ImageUrl = "https://i.ebayimg.com/images/g/U90AAOSw8pRjpi8s/s-l960.jpg", Name = "Puma GV мужские крассовки, белое золото", Price = 10000, Sold = false}
            };
        }
    }
}

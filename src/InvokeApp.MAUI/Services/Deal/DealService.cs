using InvokeApp.Shared.DTOs.Deals;

namespace InvokeApp.MAUI.Services.Deal
{
    public class DealService : IDealService
    {
        public List<BuyingDealDto> GetDeals()
        {
            return new List<BuyingDealDto>()
            {
                new BuyingDealDto(){ImageUrl = "https://udacha77.ru/upload/iblock/049/nzabzwwqtdvez402uorahf4jwv0s18hx.JPG"},
                new BuyingDealDto(){ImageUrl = "https://cache3.youla.io/files/images/720_720_out/5b/a1/5ba15b3966fb0748673b8bf2.jpg"}

            };
        }
    }
}

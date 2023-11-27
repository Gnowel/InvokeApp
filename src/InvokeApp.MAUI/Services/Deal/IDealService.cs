using InvokeApp.Shared.DTOs.Deals;

namespace InvokeApp.MAUI.Services.Deal
{
    public interface IDealService
    {
        List<BuyingDealDto> GetDeals();
    }
}

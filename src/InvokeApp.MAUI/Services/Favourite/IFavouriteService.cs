using InvokeApp.Shared.DTOs;

namespace InvokeApp.MAUI.Services.Favourite
{
    public interface IFavouriteService
    {
        List<FavouriteDto> GetFavourites();
    }
}

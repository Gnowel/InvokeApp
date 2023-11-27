using CommunityToolkit.Mvvm.Input;
using InvokeApp.MAUI.Services.Favourite;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.ViewModels.Base;
using InvokeApp.Shared.DTOs;
using System.Collections.ObjectModel;

namespace InvokeApp.MAUI.ViewModels
{
    public partial class FavoriteViewModel : BaseViewModel
    {
        private readonly IFavouriteService _favouriteService;
        public ObservableCollection<FavouriteDto> Favourites { get; set; } = new();
        public FavoriteViewModel(
            INavigationService navigationService,
            IFavouriteService favouriteService) : base(navigationService)
        {
            _favouriteService = favouriteService;
        }
        public async Task Initialize()
        {
            var favourites = _favouriteService.GetFavourites();

            Favourites.Clear();
            foreach (var product in favourites)
            {
                Favourites.Add(product);
            }
        }

        [RelayCommand]
        private void DeleteFavoriteItem(FavouriteDto removeItem)
        {
            Favourites.Remove(removeItem);
        }
    }
}

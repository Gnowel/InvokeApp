using InvokeApp.MAUI.Services.Deal;
using InvokeApp.MAUI.Services.Favourite;
using InvokeApp.MAUI.Services.Navigation;
using InvokeApp.MAUI.Services.PopupNavigation;
using InvokeApp.MAUI.Services.Product;

namespace InvokeApp.MAUI.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IPopupService, PopupService>();

            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<IDealService, DealService>();
            builder.Services.AddTransient<IFavouriteService, FavouriteService>();


            return builder;
        }
    }
}

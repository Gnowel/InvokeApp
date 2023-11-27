using InvokeApp.MAUI.ViewModels;
using InvokeApp.MAUI.ViewModels.Announcements;
using InvokeApp.MAUI.ViewModels.Popups;

namespace InvokeApp.MAUI.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<HomeViewModel>();

            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<RegisterViewModel>();
            builder.Services.AddTransient<FavoriteViewModel>();
            builder.Services.AddTransient<DealsViewModel>();
            builder.Services.AddTransient<ProductDetailViewModel>();
            builder.Services.AddTransient<PlaceProductViewModel>();
            builder.Services.AddTransient<DescriptionProductViewModel>();
            builder.Services.AddTransient<SpecifyPriceViewModel>();
            builder.Services.AddTransient<SelectLocationViewModel>();



            builder.Services.AddTransient<SortingViewModel>();
            builder.Services.AddTransient<PriceViewModel>();

            return builder;
        }
    }
}

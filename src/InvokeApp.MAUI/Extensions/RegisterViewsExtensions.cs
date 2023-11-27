using InvokeApp.MAUI.Views;
using InvokeApp.MAUI.Views.Announcements;
using InvokeApp.MAUI.Views.Popups;

namespace InvokeApp.MAUI.Extensions;

public static partial class ConfigExtensions
{
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<FavoritePage>();
        builder.Services.AddTransient<DealsPage>();
        builder.Services.AddTransient<ProductDetailPage>();
        builder.Services.AddTransient<PlaceProductPage>();
        builder.Services.AddTransient<DescriptionProductPage>();
        builder.Services.AddTransient<SpecifyPricePage>();
        builder.Services.AddTransient<SelectLocationPage>();

        builder.Services.AddTransient<SortingPopup>();
        builder.Services.AddTransient<PricePopup>();


        return builder;
    }
}


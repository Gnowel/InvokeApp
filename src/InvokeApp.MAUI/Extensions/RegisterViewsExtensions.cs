using InvokeApp.MAUI.Views;

namespace InvokeApp.MAUI.Extensions;

public static partial class ConfigExtensions
{
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();



        return builder;
    }
}


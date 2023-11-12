using InvokeApp.MAUI.ViewModels;

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

            return builder;
        }
    }
}

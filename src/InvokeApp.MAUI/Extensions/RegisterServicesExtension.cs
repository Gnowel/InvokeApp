using InvokeApp.MAUI.Services.Navigation;

namespace InvokeApp.MAUI.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            return builder;
        }
    }
}

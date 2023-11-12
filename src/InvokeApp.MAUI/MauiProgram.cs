using CommunityToolkit.Maui;
using InvokeApp.MAUI.Extensions;

namespace InvokeApp.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .RegisterFonts()
                .RegisterServices()
                .RegisterViewModels()
                .RegisterViews();


            return builder.Build();
        }
    }
}
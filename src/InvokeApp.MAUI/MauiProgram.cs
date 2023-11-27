using CommunityToolkit.Maui;
using InvokeApp.MAUI.Extensions;
using InvokeApp.MAUI.Handlers;

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

            FormHandler.RemoveBorders();

            return builder.Build();
        }
    }
}
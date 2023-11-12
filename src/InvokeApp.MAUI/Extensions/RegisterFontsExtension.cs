namespace InvokeApp.MAUI.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterFonts(this MauiAppBuilder builder)
        {
            return builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("Inter-Thin.ttf", "InterThin");
                fonts.AddFont("Inter-ExtraLight.ttf", "InterExtraLight");
                fonts.AddFont("Inter-Light.ttf", "InterLight");
                fonts.AddFont("Inter-Regular.ttf", "InterRegular");
                fonts.AddFont("Inter-Medium.ttf", "InterMedium");
                fonts.AddFont("Inter-SemiBold.ttf", "InterSemiBold");
                fonts.AddFont("Inter-Bold.ttf", "InterBold");
                fonts.AddFont("Inter-ExtraBold.ttf", "InterExtraBold");
                fonts.AddFont("Inter-Black.ttf", "InterBlack");
            });
        }
    }
}

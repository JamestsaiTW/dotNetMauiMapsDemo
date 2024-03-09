using Maui.GoogleMaps.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;

namespace MauiDemoApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MR");
                })
                .UseMauiMaps();
#if ANDROID
                builder.UseGoogleMaps();
#elif IOS
                builder.UseGoogleMaps("PASTE-YOUR-API-KEY-HERE");
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

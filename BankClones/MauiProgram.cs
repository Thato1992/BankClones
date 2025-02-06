using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace BankClones;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Define Splash Screen
        builder.ConfigureMauiHandlers(handlers =>
        {
            // No need for SplashScreenHandler override
        });

        return builder.Build();
    }
}

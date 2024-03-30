using Microsoft.Extensions.Logging;
using epj.RouteGenerator;

namespace MauiShellAutoRoutesSample
{
    //Add this sufix to search all Page in your app, like SomePage, MainPage, and create the route for them.
    [AutoRoutes("Page")]
    //If you want to create a especific route, you can add a ExtraRoute, with the page name.
    [ExtraRoute("Dashboard")]
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

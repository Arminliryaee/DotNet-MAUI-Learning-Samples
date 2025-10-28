using MauiDevelopmentCourse.Repositories;
using MauiDevelopmentCourse.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiDevelopmentCourse
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<CarListViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<CarRepository>();
            return builder.Build();
        }
    }
}

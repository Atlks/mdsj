﻿using Microsoft.Extensions.Logging;

namespace MauiApp1
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
                });

            builder.Services.AddMauiBlazorWebView();

           //for dbg
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();

            builder.Services.AddScoped<MyService>();

            return builder.Build();
        }
    }
}

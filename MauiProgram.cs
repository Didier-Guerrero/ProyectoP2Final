﻿namespace ProyectoP2Final;
using ProyectoP2Final.DataAccess;
using ProyectoP2Final.ViewModels;
using ProyectoP2Final.Views;
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
                fonts.AddFont("Aclonica-Regular", "Aclonica-Regular");
            });
		var dbContext = new ReservaDbContext();
		dbContext.Database.EnsureCreated();
		dbContext.Dispose();

		builder.Services.AddDbContext<ReservaDbContext>();

		builder.Services.AddTransient<ReservaPage>();
        builder.Services.AddTransient<ReservaViewModel>();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainViewModel>();

		Routing.RegisterRoute(nameof(ReservaPage), typeof(ReservaPage));

        return builder.Build();
	}
}

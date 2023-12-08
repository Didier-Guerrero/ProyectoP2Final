namespace ProyectoP2Final;
using ProyectoP2Final.DataAccess;
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
		var dbContext = new ReservaDbContext();
		dbContext.Database.EnsureCreated();
		dbContext.Dispose();

		return builder.Build();
	}
}

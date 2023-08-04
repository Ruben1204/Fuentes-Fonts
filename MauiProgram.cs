namespace RecursosMAUI;

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
                fonts.AddFont("Lobster-Regular.ttf", "Lobster");
                fonts.AddFont("Handjet-ExtraBold.ttf", "BoldHandjet");
                fonts.AddFont("Handjet-Regular.ttf", "Reg-Handjet");
                fonts.AddFont("ionicons.ttf", "icon");
            });

		return builder.Build();
	}
}

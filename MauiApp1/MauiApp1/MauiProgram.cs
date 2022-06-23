using MauiApp1.ViewModels;
using MauiApp1.Views;

namespace MauiApp1;

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

		builder.Services.AddTransient<RegisterNameView>();
		builder.Services.AddTransient<RegisterNameViewModel>();

		builder.Services.AddSingleton(Connectivity.Current);
		builder.Services.AddSingleton(Geolocation.Default);
		builder.Services.AddSingleton(Map.Default);

		return builder.Build();
	}
}

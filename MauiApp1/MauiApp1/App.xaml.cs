using MauiApp1.Views;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(RegisterNameView), typeof(RegisterNameView));

		MainPage = new AppShell();
	}
}

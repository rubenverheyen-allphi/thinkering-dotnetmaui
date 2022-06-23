using MauiApp1.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(RegisterNameView), true);
	}
}


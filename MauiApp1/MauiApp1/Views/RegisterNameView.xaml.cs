using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class RegisterNameView : ContentPage
{
	public RegisterNameView(RegisterNameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
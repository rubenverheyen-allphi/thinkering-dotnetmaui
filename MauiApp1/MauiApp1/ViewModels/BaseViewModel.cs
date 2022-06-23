using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    public partial class BaseViewModel
        : ObservableObject
    {
        [ObservableProperty]
        string title;
    }
}

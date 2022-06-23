using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels
{
    public partial class RegisterNameViewModel
        : BaseViewModel
    {
        public ObservableCollection<Persoon> Personen { get; } = new();

        [ObservableProperty]
        private Persoon nieuwePersoon;
        private readonly IConnectivity _connectivity;
        private readonly IGeolocation _geolocation;
        private readonly IMap _map;

        public RegisterNameViewModel(IConnectivity connectivity, IGeolocation geolocation, IMap map)
        {
            NieuwePersoon = new();
            _connectivity = connectivity;
            _geolocation = geolocation;
            _map = map;
        }

        [ICommand]
        async void Toevoegen()
        {
            //Personen.Add(NieuwePersoon);
            //NieuwePersoon = new();

            //if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            //{
            //    await Shell.Current.DisplayAlert("No Internet connection", "Please check connection", "Ok");
                
            //}
            //else
            //{
            //    await Shell.Current.DisplayAlert("YAY! Internet connection", "You have internet!", "Ok");
            //}
            var location = await _geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await _geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }

            await _map.OpenAsync(location);
        }
    }
}

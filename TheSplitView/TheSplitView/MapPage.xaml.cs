using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace TheSplitView
{

    public sealed partial class MapPage : Page
    {
        public MapPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Specify a known location
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 48.1333, Longitude = 11.5615 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MapControl1.Center = cityCenter;
            MapControl1.ZoomLevel = 14;
            MapControl1.LandmarksVisible = true;
        }
    }
}

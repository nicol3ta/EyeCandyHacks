using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;


namespace TheSplitView
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            LayoutRoot.IsPaneOpen = !LayoutRoot.IsPaneOpen;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            TextButton.Tapped += TextButton_Tapped;
            MapButton.Tapped += MapButton_Tapped;
        }

        private void MapButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(MapPage));
        }

        private void TextButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(TextPage));
        }
    }
}

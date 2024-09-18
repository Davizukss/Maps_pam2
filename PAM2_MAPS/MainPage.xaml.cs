using Microsoft.Maui.Maps;

namespace PAM2_MAPS
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var location = new Location(-25.614677663498544, -54.57692184811186);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace IzmirBisim.View
{

    public sealed partial class StartScreen : Page
    {

        public StartScreen()
        {
            this.InitializeComponent();
        }


        private void grid_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Istasyon));
        }

        private void grid_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.NasilKiralarim));
        }

        private void grid_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Fiyatlar));
        }

        private void grid_4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.UyeNoktalari));
        }

        private void grid_5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsPhoneContract", 1, 0))
            {
                PhoneCallManager.ShowPhoneCallUI("02324335155", "İzmir Bisim");
            }
        }

        private async void grid_6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:posta@onurcelikeng.com"));
        }

    }
}

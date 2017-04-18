using HtmlAgilityPack;
using IzmirBisim.Model;
using LoCar.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace IzmirBisim.View
{
    public sealed partial class Istasyon : Page
    {
        List<BisimPlace> bisimList = new List<BisimPlace>();
        Controller control = new Controller();
        Geopoint myLocation;


        public Istasyon()
        {
            this.InitializeComponent();

            ConnectApi();
        }


        private async void getMyLocation()
        {
            try
            {
                progress.IsIndeterminate = true;

                var gl = new Geolocator() { DesiredAccuracy = PositionAccuracy.High };
                var location = await gl.GetGeopositionAsync(TimeSpan.FromMinutes(5), TimeSpan.FromSeconds(5));
                myLocation = location.Coordinate.Point;

                var pin = new MapIcon()
                {
                    Title = "Konumum",
                    Location = location.Coordinate.Point,
                    Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/me.png")),
                    NormalizedAnchorPoint = new Point() { X = 0.32, Y = 0.78 },
                };

                map.MapElements.Add(pin);
                await map.TrySetViewAsync(location.Coordinate.Point, 16, 0, 0, MapAnimationKind.Bow);

                progress.IsIndeterminate = false;
            }

            catch (Exception)
            {
                progress.IsIndeterminate = false;
                control.Message("Konum ayarlarınız kapalı.", "Bir hata oluştu :(");
            }
        }

        private async void ConnectApi()
        {
            try
            {
                progress.IsIndeterminate = true;

                string url = "http://talhahavadar.com/bisim/api/";

                HttpClient client = new HttpClient();
                var data = await client.GetStringAsync(url);
                var obj = JsonConvert.DeserializeObject<Model.Station>(data);

                for (int i = 0; i < obj.count; i++)
                {
                    bisimList.Add(obj.bisimPlaces[i]);
                    PinToMap(obj.bisimPlaces[i].name, obj.bisimPlaces[i].lat, obj.bisimPlaces[i].lon);
                }

                var jayway = new Geopoint(new BasicGeoposition() { Latitude = obj.bisimPlaces[0].lat, Longitude = obj.bisimPlaces[0].lon });

                await map.TrySetViewAsync(jayway, 15, 0, 0, MapAnimationKind.Bow);

                progress.IsIndeterminate = false;
            }

            catch (Exception)
            {
                progress.IsIndeterminate = false;

                if (NetworkInformation.GetInternetConnectionProfile() == null)
                {
                    control.Message("Herhangi bir ağ bağlantısı bulunamadı. Telefon ayarlarınızı kontrol edin ve yeniden deneyin.", "Bir hata oluştu :(");
                }

                else
                {
                    #region Control (Again)

                    var newMessage = new MessageDialog("Bağlantı zaman aşımına uğradı. Tekrar denemek ister misiniz?", "Bir hata oluştu :(");
                    var button_OK = new UICommand("Evet");
                    var button_CANCEL = new UICommand("Hayır");

                    newMessage.Commands.Add(button_OK);
                    newMessage.Commands.Add(button_CANCEL);
                    IUICommand result = await newMessage.ShowAsync();

                    if (result != null && result.Label == "Evet")
                    {
                        ConnectApi();
                    }

                    #endregion
                }
            }

        }

        private void PinToMap(string name, double posX, double posY)
        {
            MapIcon icon = new MapIcon();
            BasicGeoposition pos = new BasicGeoposition();
            pos.Latitude = posX;
            pos.Longitude = posY;

            icon.Location = new Geopoint(pos);
            icon.NormalizedAnchorPoint = new Point() { X = 0.32, Y = 0.78 };
            icon.Title = name;
            icon.Visible = true;
            icon.ZIndex = int.MaxValue;
            icon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/pin.png", UriKind.RelativeOrAbsolute));

            map.MapElements.Add(icon);
        }

        private void map_MapElementClick(MapControl sender, MapElementClickEventArgs args)
        {
            MapIcon ıcon = args.MapElements.FirstOrDefault(x => x is MapIcon) as MapIcon;
            string iconName = ıcon.Title;

            BisimPlace place = new BisimPlace();

            for (int i = 0; i < bisimList.Count; i++)
            {
                if (iconName == bisimList[i].name)
                {
                    place = bisimList[i];
                    break;
                }
            }

            control.Message("Durum     " + place.state  + "\nBisiklet     " + place.availableBcycle + "\nBoş Park   " + place.emptyCount, place.name);
        }

        private void targetButton_Click(object sender, RoutedEventArgs e)
        {
            map.MapElements.Clear();
            getMyLocation();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            map.MapElements.Clear();
            ConnectApi();
        }

        private void appBar2_Click(object sender, RoutedEventArgs e)
        {
            map.MapElements.Clear();
            ConnectApi();
        }

    }
}

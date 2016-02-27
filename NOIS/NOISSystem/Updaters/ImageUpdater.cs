
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.StaticMaps;
using GoogleMapsApi.StaticMaps.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
namespace NOISSystem.Updaters
{
    public class ImageUpdater
    {
        public ImageUpdater()
        {

        }

        public void UpdateLocationImages
            (List<string> imgUrls, List<ImageParameters> imgParams, List<string> imgFilepaths)
        {
            for (int i = 0; i < imgUrls.Count; i++)
            {
                _LocationsMapUrlGenerator(imgParams[i]);
                _DownloadLocationsImage(imgUrls[i], imgFilepaths[i]);
            }
        }

        private void _DownloadLocationsImage(string imageUrl, string saveFilePath)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(imageUrl);

                using (MemoryStream mem = new MemoryStream(data))
                {
                    using (var yourImage = Image.FromStream(mem))
                    {
                        yourImage.Save(saveFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }

        // TO change label 1..n
        private string _LocationsMapUrlGenerator
            (ImageParameters imgParams, string markerColor = "green")
        {
            string locationLetter = char.ToUpper(imgParams.label[0]).ToString();
            List<ILocationString> locationsList = new List<ILocationString>();
            foreach (var longLat in imgParams.locationsLongLat)
            {
                locationsList.Add(new Location(longLat.Item1, longLat.Item2));
            }

            Marker marker = new Marker();
            marker.Locations = locationsList;
            marker.Style = new MarkerStyle();
            marker.Style.Color = markerColor;
            marker.Style.Label = locationLetter;

            StaticMapRequest request = new StaticMapRequest
                (new Location(double.Parse(imgParams.centerLocation.Item1), double.Parse(imgParams.centerLocation.Item2)), imgParams.zoom, new ImageSize(512, 512));
            request.Markers = new List<Marker> { marker };
            request.Size = new ImageSize(512, 512);

            return new StaticMapsEngine().GenerateStaticMapURL(request);
        }
    }
}
using System;
using System.Collections.Generic;

namespace NOISSystem.Updaters
{
    public class ImageParameters
    {
        public ImageParameters
            (Tuple<string, string> centerLocation, int zoom, List<Tuple<double, double>> locationsLongLat, string label)
        {
            this.centerLocation = centerLocation;
            this.zoom = zoom;
            this.locationsLongLat = locationsLongLat;
            this.label = label;
        }
        public string label;
        public Tuple<string, string> centerLocation;
        public int zoom;
        public List<Tuple<double, double>> locationsLongLat;
    }
}

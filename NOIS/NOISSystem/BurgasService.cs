namespace NOISSystem
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;
    using Models;

    public static class BurgasService
    {
        public static string GetData(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            string result;
            using (WebResponse response = webrequest.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }
            }
            return result;
        }

        public static List<Train> TrainsArrival()
        {
            string url = "http://api.travelburgas.eu/trains/arrivals";
            string json = GetData(url);
            return JsonConvert.DeserializeObject<List<Train>>(json);
        }

        public static List<Train> TrainsDeparture()
        {
            string url = "http://api.travelburgas.eu/trains/departures";
            string json = GetData(url);
            return JsonConvert.DeserializeObject<List<Train>>(json);
        }

        public static List<Taxi> Taxis()
        {
            string url = "http://api.travelburgas.eu/taxi";
            string json = GetData(url);
            return JsonConvert.DeserializeObject<List<Taxi>>(json);
        } 

        //public static List<VenueTypes> AccommodationTypes()
        //{
        //    string url = "http://api.travelburgas.eu/accommodation";
        //    string json = GetData(url);
        //    return JsonConvert.DeserializeObject<List<VenueTypes>>(json);
        //}
        //
        //public static List<Venue> Accommodations(string typeId)
        //{
        //    string url = "http://api.travelburgas.eu/accommodation/" + typeId;
        //    string json = GetData(url);
        //    return JsonConvert.DeserializeObject<List<Venue>>(json);
        //}
        //
        //public static VenueDetails AccommodationDetails(string typeId, string id)
        //{
        //    string url = "http://api.travelburgas.eu/accommodation/" + typeId + "/" + id;
        //    string json = GetData(url);
        //    return JsonConvert.DeserializeObject<VenueDetails>(json);
        //}
    }
}

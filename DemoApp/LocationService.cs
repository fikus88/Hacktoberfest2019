using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Profit365.GeoIP.Models;

namespace DemoApp
{
    public static class LocationService
    {
        public static IGeoData GetLocation()
        {
            var provider = new Profit365.GeoIP.GeoLocationProvider();

            return provider.GetLocationByIP(GetExternalIP());
        }
        
        private static string GetExternalIP()
        {
            // External IP Address (get your external IP locally)  
            return new WebClient().DownloadString("http://icanhazip.com"); 
        }
    }
}
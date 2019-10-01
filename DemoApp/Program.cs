using System;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Profit365.GeoIP.Models;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var loc = LocationService.GetLocation();
            var rawOut = JsonConvert.DeserializeObject<dynamic>(loc.raw);
            // Set the message
            String message = $"Hello {rawOut.city}, {rawOut.country} .NET Hacktoberfest!";

            // Print out the message 5 times
            for(int i = 0; i <= 5; i++) {
                Console.WriteLine(message);
            }
            
            
        }

       
        
       
    }
}

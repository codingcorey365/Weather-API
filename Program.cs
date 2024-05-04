using System.Runtime.InteropServices.JavaScript;
using Newtonsoft.Json.Linq;

namespace Weather_API
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            string zipcode = Console.ReadLine();

            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?zip={zipcode}&units=imperial&appid={APIKey}";
            
            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");
        }
    }
}
// ------------------------------------------------------------------------
// ------------------------------------------------------------------------

/*
 * latitude and longitude for Belton, Missouri zip 64012
 * https://api.openweathermap.org/data/2.5/weather?lat=38.8120&lon=94.5319&appid=b26d483ba35fd71e32195fb502724a19
 */

/*
 *
 */

/*
 *
 */

// ------------------------------------------------------------------------
// ------------------------------------------------------------------------
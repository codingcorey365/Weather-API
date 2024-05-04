﻿using Newtonsoft.Json.Linq;

namespace Weather_API;

public class WeatherMap
{
    public static double GetTemp(string apiCall)
    {
        var client = new HttpClient();
        var response = client.GetStringAsync(apiCall).Result;
        var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
        return temp;
    }
}
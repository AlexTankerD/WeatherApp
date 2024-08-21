using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model.YandexAPI.YandexGeocodeApi;
using WeatherApp.Model.YandexAPI.YandexWeatherApi;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public static class YandexWeatherAPI
	{
		public static List<WeatherResponce> GetWeatherResponces(string Region)
		{
			List<WeatherResponce> weatherResponces = new List<WeatherResponce>();
			List<Position> position = YandexGeocodeAPI.GetPosition(Region);
			Position positionItem = position[1];
			
				string url = $"https://api.weather.yandex.ru/v2/informers?lat={positionItem.Latitude}&lon={positionItem.Longitude}&lang=ru_RU";
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				request.Headers.Add("X-Yandex-Weather-Key: 96c75238-b183-418e-8b62-74ff090c1479");
				HttpWebResponse Webresponse = (HttpWebResponse)request.GetResponse();
				string response;
				using (StreamReader reader = new StreamReader(Webresponse.GetResponseStream()))
				{
					response = reader.ReadToEnd();
				}
				WeatherResponce fact = JsonConvert.DeserializeObject<WeatherResponce>(response);
				weatherResponces.Add(fact);
			
			return weatherResponces;

		}
	}
}

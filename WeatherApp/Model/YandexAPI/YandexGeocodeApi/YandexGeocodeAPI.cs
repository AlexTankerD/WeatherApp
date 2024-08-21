using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexGeocodeApi
{
	public static class YandexGeocodeAPI
	{
		public static List<Position> GetPosition(string Region)
		{
			string url = $"https://geocode-maps.yandex.ru/1.x?apikey=da319476-5b18-48dd-a576-de4fa36b5868&geocode={Region}&format=json";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";
			HttpWebResponse Webresponse = (HttpWebResponse)request.GetResponse();
			string response;
			using (StreamReader reader = new StreamReader(Webresponse.GetResponseStream()))
			{
				response = reader.ReadToEnd();
			}
			GeocodeResponse georesponce = JsonConvert.DeserializeObject<GeocodeResponse>(response);
			List<Position> result = new List<Position>();
			foreach(FeatureMember featuremember in georesponce.Response.GeoObjectCollection.FeatureMember)
			{
				Position position = new Position();
				string[] pos = featuremember.GeoObject.Point.Pos.Split();
				position.Longitude = pos[0];
				position.Latitude = pos[1];
				result.Add(position);
			}
			return result;
		}
	}
}

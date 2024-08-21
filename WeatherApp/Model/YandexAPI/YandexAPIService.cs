using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model.YandexAPI;
using WeatherApp.Model.YandexAPI.YandexWeatherApi;

namespace WeatherApp.Model.YandexAPI
{
	public static class YandexAPIService
	{
		public static WeatherResponce GetWeatherResponces(string Region)
		{
			try
			{
				List<WeatherResponce> WeatherResponces = YandexWeatherApi.YandexWeatherAPI.GetWeatherResponces(Region);
				return WeatherResponces[0];
			}
			catch(System.ArgumentOutOfRangeException)
			{
				return null;
			}
		}
	}
}

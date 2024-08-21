using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class GeoObject
	{
		public dynamic district { get; set; }
		public dynamic locality { get; set; }
		public Province province { get; set; }
		public Country country { get; set; }
	}
}

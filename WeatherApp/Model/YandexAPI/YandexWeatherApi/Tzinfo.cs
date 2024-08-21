using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class Tzinfo
	{
		public string name { get; set; }
		public string abbr { get; set; }
		public bool dst { get; set; }
		public int offset { get; set; }
	}

}

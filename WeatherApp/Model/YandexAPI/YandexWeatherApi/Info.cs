using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class Info
	{
		public bool n { get; set; }
		public int geoid { get; set; }
		public string url { get; set; }
		public float lat { get; set; }
		public float lon { get; set; }
		public Tzinfo tzinfo { get; set; }
		public int def_pressure_mm { get; set; }
		public int def_pressure_pa { get; set; }
		public string slug { get; set; }
		public int zoom { get; set; }
		public bool nr { get; set; }
		public bool ns { get; set; }
		public bool nsr { get; set; }
		public bool p { get; set; }
		public bool f { get; set; }
		public bool _h { get; set; }
	}
}

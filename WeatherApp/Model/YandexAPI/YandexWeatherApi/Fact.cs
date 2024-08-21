using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class Fact
	{
		public float obs_time { get; set; }
		public float uptime { get; set; }
		public float temp { get; set; }
		public float feels_like { get; set; }
		public string icon { get; set; }
		public string condition { get; set; }
		public double cloudness { get; set; }
		public float prec_type { get; set; }
		public float prec_prob { get; set; }
		public float prec_strength { get; set; }
		public bool is_thunder { get; set; }
		public double wind_speed { get; set; }
		public string wind_dir { get; set; }
		public float pressure_mm { get; set; }
		public float pressure_pa { get; set; }
		public float humidity { get; set; }
		public string daytime { get; set; }
		public bool polar { get; set; }
		public string season { get; set; }
		public string source { get; set; }
		public double soil_moisture { get; set; }
		public float soil_temp { get; set; }
		public float uv_index { get; set; }
		public double wind_gust { get; set; }
	}
}

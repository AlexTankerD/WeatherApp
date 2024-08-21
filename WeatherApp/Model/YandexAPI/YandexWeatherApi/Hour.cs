using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class Hour
	{
		public string hour { get; set; }
		public float hour_ts { get; set; }
		public float temp { get; set; }
		public float feels_like { get; set; }
		public string icon { get; set; }
		public string condition { get; set; }
		public double cloudness { get; set; }
		public float prec_type { get; set; }
		public float prec_strength { get; set; }
		public bool is_thunder { get; set; }
		public string wind_dir { get; set; }
		public double wind_speed { get; set; }
		public double wind_gust { get; set; }
		public float pressure_mm { get; set; }
		public float pressure_pa { get; set; }
		public float humidity { get; set; }
		public float uv_index { get; set; }
		public float soil_temp { get; set; }
		public double soil_moisture { get; set; }
		public float prec_mm { get; set; }
		public float prec_period { get; set; }
		public float prec_prob { get; set; }
	}
}

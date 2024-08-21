using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class WeatherResponce
	{
		public int now { get; set; }
		public DateTime now_dt { get; set; }
		public Info info { get; set; }
		public GeoObject geo_object { get; set; }
		public Yesterday yesterday { get; set; }
		public Fact fact { get; set; }
		public IList<Forecast> forecasts { get; set; }
	}
}

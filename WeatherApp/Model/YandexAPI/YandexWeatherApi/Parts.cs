using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.YandexAPI.YandexWeatherApi
{
	public class Parts
	{
		public Day day { get; set; }
		public Night night { get; set; }
		public Evening evening { get; set; }
		public NightShort night_short { get; set; }
		public DayShort day_short { get; set; }
		public Morning morning { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherApp.Model
{
	public class ConditionConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
				return null;
			if ((string)value == "clear")
				return "Ясно";
			if ((string)value == "partly-сloudy")
				return "Малооблачно";
			if ((string)value == "cloudy")
				return "Облачно с прояснениями";
			if ((string)value == "overcast")
				return "Пасмурно";
			if ((string)value == "light-rain")
				return "Небольшой дождь";
			if ((string)value == "rain")
				return "Дождь";
			if ((string)value == "heavy-rain")
				return "Сильный дождь";
			if ((string)value == "showers")
				return "Ливень";
			if ((string)value == "wet-snow")
				return "Небольшой снег";
			if ((string)value == "snow")
				return "Снег";
			if ((string)value == "snow-showers")
				return "Снегопад";
			if ((string)value == "hail")
				return "Град";
			if ((string)value == "thunderstorm")
				return "Гроза";
			if ((string)value == "thunderstorm-with-rain")
				return "Дождь с грозой";
			if ((string)value == "thunderstorm-with-hail")
				return "Гроза с градом";
			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

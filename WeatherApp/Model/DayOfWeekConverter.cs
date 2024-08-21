using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherApp.Model
{
    public class DayOfWeekConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			DateTime dateValue = DateTime.Parse(value.ToString());
			string dayofweek = dateValue.DayOfWeek.ToString();
			if (dayofweek == "Monday")
				return $"Понедельник, {value}";
			if (dayofweek == "Tuesday")
				return $"Вторник, {value}";
			if (dayofweek == "Wednesday")
				return $"Среда, {value}";
			if (dayofweek == "Thursday")
				return $"Четверг, {value}";
			if (dayofweek == "Friday")
				return $"Пятница, {value}";
			if (dayofweek == "Saturday")
				return $"Суббота, {value}";
			if (dayofweek == "Sunday")
				return $"Воскресенье, {value}";
			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

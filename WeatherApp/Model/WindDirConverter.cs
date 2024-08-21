using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherApp.Model
{
	public class WindDirConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
				return null;
			if ((string)value == "nw")
				return "Северо-Западное";
			if ((string)value == "n")
				return "Северное";
			if ((string)value == "ne")
				return "Северо-Восточное";
			if ((string)value == "w")
				return "Западное";
			if ((string)value == "e")
				return "Восточное";
			if ((string)value == "se")
				return "Южно-Восточное";
			if ((string)value == "s")
				return "Южное";
			if ((string)value == "sw")
				return "Южно-Западное";
			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

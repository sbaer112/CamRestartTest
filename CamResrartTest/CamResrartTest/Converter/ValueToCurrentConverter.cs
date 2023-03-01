#region using
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

#endregion using

namespace CamResrartTest.Converter
{
	public class ValueToCurrentConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			if (value.ToString() == "False" || value.ToString() == "false" || value.ToString() == "FALSE")
			{
				return "Disabled";
			}
			else if (value.ToString() == "True" || value.ToString() == "true" || value.ToString() == "TRUE")
			{
				return "Enabled";
			}
			return value.ToString();
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class ValueToCurrentConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

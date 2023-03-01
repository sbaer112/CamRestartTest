#region using
using System;
using System.Globalization;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class ProcentDivicderConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return 100 / System.Convert.ToInt32(value);
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
		#endregion ConvertBack

	}//END class ProcentDivicderConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

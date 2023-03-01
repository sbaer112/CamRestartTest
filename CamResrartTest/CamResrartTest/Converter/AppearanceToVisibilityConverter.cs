#region using
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class AppearanceToVisibilityConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (System.Convert.ToString(value) == (System.Convert.ToString(parameter)))
			{
				return Visibility.Visible;
			}
			if (System.Convert.ToString(parameter) == (System.Convert.ToString(value)))
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END  
		#endregion ConvertBack

	}//END class AppearanceToVisibilityConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

#region using
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class boolToNotVisibilityConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}//END Convert
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack 

	}//END class boolToNotVisibilityConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

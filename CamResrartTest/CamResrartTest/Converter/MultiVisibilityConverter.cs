#region using
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class MultiVisibilityConverter : IMultiValueConverter
	{
		#region Convert
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			foreach (var value in values)
			{
				if (System.Convert.ToBoolean(value))
				{
					return Visibility.Visible;
				}
			}

			return Visibility.Collapsed;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class MultiVisibilityConverter : IMultiValueConverter 

}//END namespace CamResrartTest.Converter 

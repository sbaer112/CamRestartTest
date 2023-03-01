#region using
using System;
using System.Globalization;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class BooleanInverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			try
			{
				return !(System.Convert.ToBoolean(value));
			}
			catch (Exception)
			{
				return true;
			}
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack
		#endregion ConvertBack

	}//END class BooleanInverter : IValueConverter 

}//END namespace CamResrartTest.Converter

#region using
using System;
using System.Globalization;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class BooleanToParameter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (System.Convert.ToBoolean(value))
			{
				return parameter;
			}
			else
			{
				return 0;
			}
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class BooleanToParameter : IValueConverter 

}//END namespace CamResrartTest.Converter

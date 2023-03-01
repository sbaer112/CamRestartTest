#region using
using System;
using System.Globalization;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class StringToBoolConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			try
			{
				if (value.ToString() == "true" || value.ToString() == "True" || System.Convert.ToInt32(value) >= 1)
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
			return false;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class StringToBoolConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

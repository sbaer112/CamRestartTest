#region using
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

#endregion usng

namespace CamResrartTest.Converter
{
	public class ValueToColorConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			SolidColorBrush myColor = new SolidColorBrush();
			int input = System.Convert.ToByte(value);
			byte r = System.Convert.ToByte(input * (255 / 100));
			byte b = System.Convert.ToByte((100 - input) * (255 / 100));
			byte g = 30;
			myColor = new SolidColorBrush(Color.FromArgb(0xFF, r, g, b));
			return myColor;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class ValueToColorConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

#region using
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

#endregion using

namespace CamResrartTest.Converter
{
	public class StringToFiguresConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				try
				{
					var path = new Path();
					path.Data = Geometry.Parse(value.ToString());
					return path.Data;
				}
				catch (Exception)
				{
				}
			}
			return null;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class StringToFiguresConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

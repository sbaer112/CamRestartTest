#region uisng
using System;
using System.Globalization;
using System.Windows.Data;

#endregion using

namespace CamResrartTest.Converter
{
	public class StringToImageSourceConverter : IValueConverter
	{
		#region Convert
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			System.Windows.Media.Imaging.BitmapImage imageBitmap = null;
			if (value != null)
			{
				string stringPath = value.ToString();
				Uri imageUri = new Uri(stringPath, UriKind.Relative);
				imageBitmap = new System.Windows.Media.Imaging.BitmapImage(imageUri);
			}
			return imageBitmap;
		}//END Convert 
		#endregion Convert

		#region ConvertBack
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}//END ConvertBack 
		#endregion ConvertBack

	}//END class StringToImageSourceConverter : IValueConverter 

}//END namespace CamResrartTest.Converter 

#region using
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#endregion using

namespace CamResrartTest.Model
{
	public class ModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		#region SetField
		protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value))
			{
				return false;
			}

			field = value;
			this.NotifyPropertyChanged(propertyName);

			return true;
		}//END SetField 
		#endregion SetField

		#region NotifyPropertyChanged
		protected void NotifyPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion NotifyPropertyChanged

	}//END class ModelBase : INotifyPropertyChanged 

}//END namespace

#region using
using CamResrartTest.Command;
using CamResrartTest.Model;
//using CamResrartTest.Data;
//using CamResrartTest.Work;
//using CamResrartTest.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

#endregion using

namespace CamResrartTest.View
{
	class ViewModel : ModelBase
	{
		#region VAR
		/******************************************************************************/
		/* VAR                                                                        */
		/******************************************************************************/
		private static ViewModel _createInstance = null;
		/******************************************************************************/
		#endregion VAR

		#region CreateInstance
		public static ViewModel CreateInstance
		{
			get
			{
				if (null == _createInstance)
				{
					_createInstance = new ViewModel();
				}

				return _createInstance;
			}
		}//END CreateInstance
		#endregion CreateInstance

		#region ViewModel
		public ViewModel()
		{
		}//END ViewModel 
		#endregion ViewModel

	}//END class ViewModel : ModelBase 

}//END namespace 

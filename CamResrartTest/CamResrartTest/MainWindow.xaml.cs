#region using
using CamResrartTest.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

#endregion using

namespace CamResrartTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region MainWindow
		public MainWindow()
		{
			InitializeComponent();

			ViewModel vm = ViewModel.CreateInstance;
			this.DataContext = vm;

		}//END MainWindow
		#endregion MainWindow

		#region OnClosing
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			//close logic here


			base.OnClosing(e);
		}//END OnClosing 
		#endregion OnClosing

	}//END class MainWindow : Window 

}//END namespace CamResrartTest

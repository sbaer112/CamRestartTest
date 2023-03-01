#region using
using System;
using System.Windows.Input;

#endregion

namespace CamResrartTest.Command
{
	class RelayCommand : ICommand
	{
		#region VAR
		/***************************************************************************/
		/* VAR                                                                     */
		/***************************************************************************/
		private readonly Action<object> execute;

		private readonly Predicate<object> canExecute;
		/***************************************************************************/
		#endregion VAR

		#region RelayCommand (Action<object> execute) : this(execute, null)
		public RelayCommand(Action<object> execute) : this(execute, null)
		{
		}//END RelayCommand (Action<object> execute) : this(execute, null)
		#endregion RelayCommand (Action<object> execute) : this(execute, null)

		#region RelayCommand(Action<object> execute, Predicate<object> canExecute)
		public RelayCommand(Action<object> execute, Predicate<object> canExecute)
		{
			if (execute == null)
			{
				// ReSharper disable once LocalizableElement
				throw new ArgumentNullException(nameof(execute), "Execute method missing");
			}

			this.execute = execute;
			this.canExecute = canExecute;
		}//END RelayCommand(Action<object> execute, Predicate<object> canExecute)
		#endregion RelayCommand(Action<object> execute, Predicate<object> canExecute)

		#region CanExecuteChanged
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}

			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}//END CanExecuteChanged 
		#endregion CanExecuteChanged

		#region CanExecute
		public bool CanExecute(object parameter)
		{
			return this.canExecute?.Invoke(parameter) ?? true;
		}//END CanExecute 
		#endregion

		#region Execute
		public void Execute(object parameter)
		{
			this.execute(parameter);
		}//END Execute 
		#endregion CanExecute

	}//END class RelayCommand : ICommand 

}//END namespace

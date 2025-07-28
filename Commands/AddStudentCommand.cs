using System;
using System.Windows.Input;
using _28thJuly.Dialogs;

namespace _28thJuly.ViewModels
{
    public class AddStudentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> _executeAction;
        public AddStudentCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }
        public bool CanExecute(object parameter)
        {
            return true; // You can add logic here to enable/disable the command
        }
        public void Execute(object Parameter)
        {
            _executeAction?.Invoke(Parameter);
        }
    }
}

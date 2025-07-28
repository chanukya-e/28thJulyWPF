using System;
using System.Windows;
using System.Windows.Input;

namespace _28thJuly.Commands
{
    public class SaveCommand: ICommand
    {
        public event EventHandler CanExecuteChanged;
    
        public bool CanExecute(object parameter)
        {
            return true; // You can add logic here to enable/disable the command
        }
        public void Execute(object parameter)
        {
            MessageBox.Show("Save Command Executed");
        }
    }
}

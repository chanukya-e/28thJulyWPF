using System;
using System.Windows;
using _28thJuly.Interfaces;

namespace _28thJuly.Services
{
    public class DialogService : IDialogService
    {

        public bool? ShowDialog(object viewModel, string windowName)
        {
            var windowType = Type.GetType(windowName);
            var window = (Window)Activator.CreateInstance(windowType);
            window.DataContext = viewModel;

            return window?.ShowDialog();
        }
    }
}

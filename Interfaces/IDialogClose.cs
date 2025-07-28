using System;

namespace _28thJuly.Interfaces
{
   public  interface IDialogClose
    {
        event EventHandler <DialogCloseRequestedEventArgs> DialogCloseRequested;
    }

    public class DialogCloseRequestedEventArgs : EventArgs

    {
        public bool? DialogResult { get; }

        public DialogCloseRequestedEventArgs(bool? dialogResult)
        {
            this.DialogResult = dialogResult;
        }
    }
}

using _28thJuly.Commands;
using _28thJuly.Models;
using System.Windows.Input;
using _28thJuly.Commands;
using _28thJuly.Models;


namespace _28thJuly.ViewModels
{
    public class AddStudentDialogViewModel
    {
        public AddStudentDialogViewModel()
        {
            
            SaveCommand = new SaveCommand();
            CancelCommand = new CancelCommand();
        }
        public Student Student { get; set; } = new Student();

        public ICommand SaveCommand { get; set; }

        public ICommand CancelCommand { get; set; }
    }
}

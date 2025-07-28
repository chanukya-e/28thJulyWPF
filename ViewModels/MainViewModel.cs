using _28thJuly.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using _28thJuly.Dialogs;
using _28thJuly.Interfaces;
using _28thJuly.Services;
using _28thJuly.ObjectModel;
using System.Collections.ObjectModel;



namespace _28thJuly.ViewModels
{
    public class MainViewModel
    {
        private IDialogService _dialogService;
        public MainViewModel()
        {
            _dialogService = new DialogService();

            FillSampleStudents();

            AddStudentCommand = new AddStudentCommand(OpenStudentDialog);
        }

        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();

        public ICommand AddStudentCommand { get; set; }

        private void FillSampleStudents()
        {

            Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Doe",
                DOB = new DateTime(2000, 1, 1),
                Address = "123 Main"
            });
            Students.Add(new Student
            {
                FirstName = "CHanu",
                LastName = "Kumar",
                DOB = new DateTime(1999, 5, 15),
                Address = "456 Elm"
            });
        }
        private void OpenStudentDialog(object parameter)
        {
            // Logic to open the AddStudentDialog
            var viewModel = new AddStudentDialogViewModel();
            _dialogService.ShowDialog(viewModel,typeof(AddStudentDialog).FullName);

            if (viewModel.Student != null)
            {
                Students.Add(viewModel.Student);
            }
        }
    }

}

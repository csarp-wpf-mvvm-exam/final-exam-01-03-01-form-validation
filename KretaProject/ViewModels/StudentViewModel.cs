using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaProject.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KretaProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();
        [ObservableProperty]
        private Student selectedStudent = new();

        [RelayCommand]
        private void AddStudent()
        {
            Students.Add(SelectedStudent);
        }

        [RelayCommand]
        private void UpdateStudent()
        {
        }

        [RelayCommand]
        private void DeleteStudent()
        {
            Students.Remove(SelectedStudent);
            SelectedStudent = new Student();
        }
    }
}

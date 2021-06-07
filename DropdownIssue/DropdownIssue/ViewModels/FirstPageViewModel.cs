using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DropdownIssue.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {

        public FirstPageViewModel()
        {
            students = GetStudents();
        }

        public ObservableCollection<StudentViewModel> students;

        public ObservableCollection<StudentViewModel> Students
        {

            get { return students; }

            set
            {
                students = value;
                OnPropertyChanged();
            }
        }
       
        public Command AddMore
        {
            get
            {
                return new Command(AddData);
            }
        }

        private void AddData()
        {
            Console.WriteLine("Student info is : ");
            
            students.Add(new StudentViewModel
            {
                Name = "Default Name",
                Surname = "Default Surname",
            });
            
        }

        private ObservableCollection<StudentViewModel> GetStudents()
        {
            return new ObservableCollection<StudentViewModel>
            {
                new StudentViewModel
                {
                    Name = "Default Name",
                    Surname = "Default Surname"
            }
            };
        }
    }
}

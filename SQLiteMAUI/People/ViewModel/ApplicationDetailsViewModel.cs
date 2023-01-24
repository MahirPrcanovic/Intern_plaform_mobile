using AndroidX.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using People.Data;

namespace People.ViewModel
{
    public partial class ApplicationDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        string text = "neki tekst test";
        [ObservableProperty]
        string student = "";
        [ObservableProperty]
        string firstLetterName;
        [ObservableProperty]
        string firstLastName;
        [ObservableProperty]
        string educationLevel;
        [ObservableProperty]
        string cVUrl;
        [ObservableProperty]
        string coverLetter;
        public ApplicationDetailsViewModel(int studentID)
        {
            student = studentID.ToString();
            text = studentID.ToString();
            var foundStudent = App.PersonRepository.GetSingleStudent(studentID);
            if (foundStudent == null) Shell.Current.GoToAsync("..");
            text = foundStudent.Email;
            firstLetterName = foundStudent.FirstName[0] + "";
            firstLastName = foundStudent.FirstName + " " + foundStudent.LastName;
            educationLevel = foundStudent.EducationLevel;
            cVUrl = foundStudent.CV;
            CoverLetter = foundStudent.CoverLetter;
        }
    }
}

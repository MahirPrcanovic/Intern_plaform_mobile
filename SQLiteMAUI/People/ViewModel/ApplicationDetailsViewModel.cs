using CommunityToolkit.Mvvm.ComponentModel;
using People.Data;

namespace People.ViewModel
{
    public partial class ApplicationDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        string text = "neki tekst test";
        [ObservableProperty]
        string student = "";
        public ApplicationDetailsViewModel(int studentID)
        {
            student = studentID.ToString();
            text = studentID.ToString();
            var foundStudent = App.PersonRepository.GetSingleStudent(studentID);
            text = foundStudent.Email;
        }
    }
}

using Android.Media;
using AndroidX.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using People.Data;
using People.Models;
using People.Pages;
using System.Windows.Input;

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
        [ObservableProperty]
        string entryText;
        Student foundStudent;
        public ApplicationDetailsViewModel(int studentID)
        {
            student = studentID.ToString();
            text = studentID.ToString();
            foundStudent = App.PersonRepository.GetSingleStudent(studentID);
            if (foundStudent == null) Shell.Current.GoToAsync("..");
            text = foundStudent.Email;
            firstLetterName = foundStudent.FirstName[0] + "";
            firstLastName = foundStudent.FirstName + " " + foundStudent.LastName;
            educationLevel = foundStudent.EducationLevel;
            cVUrl = foundStudent.CV;
            CoverLetter = foundStudent.CoverLetter;
        }
        [RelayCommand]
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
        [RelayCommand]
        public void AddNewComment()
        {
            App.CommentRepository.AddNewComment(new Comments {Text = entryText, user= App.loggedInUser, student= foundStudent });
        }
    }
}

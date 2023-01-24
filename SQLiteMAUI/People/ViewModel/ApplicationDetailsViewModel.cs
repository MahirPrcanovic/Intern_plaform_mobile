using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using People.Data;
using People.Models;
using People.Pages;
using System.Collections.ObjectModel;
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
        [ObservableProperty]
        ObservableCollection<Comments> commentList;
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
            commentList = App.CommentRepository.GetAllStudentsComments(foundStudent.Id).ToObservableCollection();
        }
        [RelayCommand]
        public void AddNewComment()
        {
            var comment = new Comments { CommentText = entryText, UserId = App.loggedInUser.Id, StudentId = foundStudent.Id };
            App.CommentRepository.AddNewComment(comment);
            commentList.Add(comment);
            entryText = string.Empty;
        }
    }
}

using Microsoft.Maui.ApplicationModel.Communication;
using People.Data;
using People.Models;
using People.Pages;
using System.Collections.Generic;

namespace People;

public partial class MainPage : ContentPage
{
    StudentRepository repository;
	public MainPage(StudentRepository studentRepository)
	{
		InitializeComponent();
        repository = studentRepository;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string UserName = email.Text;
        string Password = password.Text;
        if (UserName == null || Password == null)
        {
            await DisplayAlert("Warning", "Please input email and password", "OK");
            return;
        }
        await DisplayAlert("Tryout", "Username is : " + UserName + "\n Password is : " + Password, "OK");
        await Navigation.PushAsync(new ApplicantsPage());
        //repository.AddNewStudent(UserName.ToString());
        //await DisplayAlert("E", repository.StatusMessage, "OK");
    }

    //public void OnGetButtonClicked(object sender, EventArgs args)
    //{
    //    statusMessage.Text = "";

    //    List<Student> students = repository.GetAllStudents();
    //    studentList.ItemsSource = students;
    //}

}


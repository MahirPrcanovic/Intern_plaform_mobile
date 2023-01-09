using Microsoft.Maui.ApplicationModel.Communication;
using People.Data;
using People.Models;
using People.Pages;
using System.Collections.Generic;

namespace People;

public partial class MainPage : ContentPage
{
    UserRepository repository;
	public MainPage(UserRepository studentRepository)
	{
		InitializeComponent();
        repository = studentRepository;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string Email = email.Text;
        string Password = password.Text;
        if (Email == null || Password == null)
        {
            await DisplayAlert("Warning", "Please input email and password", "OK");
            return;
        }
        await DisplayAlert("Tryout", "Username is : " + Email + "\n Password is : " + Password, "OK");
        await Navigation.PushAsync(new ApplicantsPage());
        await repository.AddNewUser(Email.ToString(), Password.ToString());
        await DisplayAlert("Registered successfully", repository.StatusMessage, "OK");
        //repository.AddNewStudent(UserName.ToString());
        //await DisplayAlert("E", repository.StatusMessage, "OK");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterApplicantPage());
    }
}



using People.Data;
using People.Models;
using People.Pages;

namespace People;

public partial class MainPage : ContentPage
{
    UserRepository repository;
    PersonRepository personRepo;

  

    //public MainPage()
    //{
    //}

    public MainPage(UserRepository studentRepository,PersonRepository per)
	{
		InitializeComponent();
        personRepo = per;
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
        await Navigation.PushAsync(new ApplicantsPage(personRepo));
        //await repository.AddNewUser(Email.ToString(), Password.ToString());
        //await DisplayAlert("Registered successfully", repository.StatusMessage, "OK");
        //repository.AddNewStudent(UserName.ToString());
        //await DisplayAlert("E", repository.StatusMessage, "OK");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterApplicantPage(personRepo,repository));
    }
}


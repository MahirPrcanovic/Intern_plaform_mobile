
using People.Data;
using People.Models;
using People.Pages;
namespace People;

public partial class MainPage : ContentPage
{
    UserRepository repository;
    PersonRepository personRepo;
    public MainPage(UserRepository studentRepository,PersonRepository per)
	{
		InitializeComponent();
        personRepo = per;
        repository = studentRepository;
        //BindingContext = m;
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

        //repository.AddNewUser(Email, Password);
        //await DisplayAlert("A", repository.StatusMessage, "OK");
        if (repository.DoesExist(Email, Password) == true)
        {
            await Shell.Current.GoToAsync(nameof(ApplicantsPage));
        }
        else
        {
            await DisplayAlert("Error", "Please check your credentials", "OK");
        }
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


using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using People.Data;
using People.Models;
using People.Pages;
namespace People;

public partial class MainPage : ContentPage
{
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    private string toastText = "";
    private ToastDuration duration = ToastDuration.Short;
    private double fontSize = 14;
    public MainPage()
	{

		InitializeComponent();

        //BindingContext = m;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string Email = email.Text;
        string Password = password.Text;
        //App.UserRepository.AddNewUser(Email.ToString(), Password.ToString());
        if (Email == null || Password == null)
        {
            toastText = "Please input email and password";
            var toast = Toast.Make(toastText, duration, fontSize);
            await toast.Show(cancellationTokenSource.Token);
            return;
        }
        //await DisplayAlert("Tryout", "Username is : " + Email + "\n Password is : " + Password, "OK");
        if (App.UserRepository.DoesExist(Email, Password) == true)
        {
            App.loggedInUser = App.UserRepository.getUser(Email);
            await Shell.Current.GoToAsync(nameof(ApplicantsPage));
        }
        else
        {
            toastText= "Please check your credentials";
            var toast = Toast.Make(toastText, duration, fontSize);
            await toast.Show(cancellationTokenSource.Token);
            //await DisplayAlert("Error", "Please check your credentials", "OK");
        }
        
        //await DisplayAlert("Registered successfully", repository.StatusMessage, "OK");
        //repository.AddNewStudent(UserName.ToString());
        //await DisplayAlert("E", repository.StatusMessage, "OK");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterApplicantPage());
    }
}


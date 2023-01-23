using People.Data;

namespace People.Pages;
//public class Item
//{
//    public int Id;
//    public string Name;
//}
public partial class RegisterApplicantPage : ContentPage
{
    public string SelectedEducation { get; set; }
    List<string> Education;
    public RegisterApplicantPage()
	{
		InitializeComponent();
        Education = new List<string> { "High School", "Bachelor Undergraduate", "Bachelor Graduate","Master's Undergraduate", "Master's Graduate","Doctorate" };
        picker.ItemsSource = Education;
        BindingContext = this;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("..");
        //await Navigation.PushAsync(new MainPage(userRep,repository));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        //Sign up
        int pickerIndex = picker.SelectedIndex;
        string EmailG = email.Text;
        string LastName = lastName.Text;
        string FirstName = firstName.Text;
        string CL = coverLetter.Text;
        string CV = cv.Text;
        if (EmailG == null || LastName == null || FirstName == null || pickerIndex < 0 || CL == null || CV == null)
        {
            await DisplayAlert("Invalid Data", "Please insert all fields.", "Ok");
            return;
        }
        App.PersonRepository.AddNewStudent(new Models.Student { Email = EmailG, LastName = LastName, FirstName = FirstName, CoverLetter = CL, CV = CV, EducationLevel = Education[pickerIndex] });
        await DisplayAlert("Confirmation", App.PersonRepository.StatusMessage, "Ok");
    }
}
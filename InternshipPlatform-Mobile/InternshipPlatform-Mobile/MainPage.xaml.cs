namespace InternshipPlatform_Mobile;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Title","The email is "+email.Text,"OK");
    }
}


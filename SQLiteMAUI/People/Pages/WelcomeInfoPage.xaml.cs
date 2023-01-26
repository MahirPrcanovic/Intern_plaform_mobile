using People.ViewModel;

namespace People.Pages;

public partial class WelcomeInfoPage : ContentPage
{
	public WelcomeInfoPage()
	{
		InitializeComponent();
		BindingContext = new WelcomeInfoViewModel();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterApplicantPage());
    }
}
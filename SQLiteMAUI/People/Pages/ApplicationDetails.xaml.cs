using People.ViewModel;

namespace People.Pages;

public partial class ApplicationDetails : ContentPage
{
	public ApplicationDetails(int studentID)
	{
		InitializeComponent();
		BindingContext = new ApplicationDetailsViewModel(studentID);
	}
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ApplicantsPage());
    }
}
using People.ViewModel;

namespace People.Pages;

public partial class SelectionsPage : ContentPage
{
	public SelectionsPage()
	{
		InitializeComponent();
        BindingContext = new SelectionPageViewModel();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ApplicantsPage());
    }
}
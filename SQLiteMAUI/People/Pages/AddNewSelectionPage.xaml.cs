using CommunityToolkit.Mvvm.Input;
using People.ViewModel;

namespace People.Pages;

public partial class AddNewSelectionPage : ContentPage
{
	public AddNewSelectionPage()
	{
		InitializeComponent();
		BindingContext = new AddNewSelectionViewModel();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}
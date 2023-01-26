using People.Models;
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
    private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniSelection = (Selections)myListView.SelectedItem;
        await Navigation.PushAsync(new SelectionDetailsPage(odabraniSelection.Id));
    }
}
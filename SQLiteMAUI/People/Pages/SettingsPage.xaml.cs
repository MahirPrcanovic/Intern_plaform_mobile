using People.ViewModel;

namespace People.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
		BindingContext = new SettingsPageViewModel();
	}
}
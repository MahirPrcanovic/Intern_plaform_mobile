namespace People.Pages;

public partial class ApplicantsPage : ContentPage
{
	string UserName;
	public ApplicantsPage()
	{
		InitializeComponent();
		UserName = "Mahir";
		BindingContext= this;
	}
}
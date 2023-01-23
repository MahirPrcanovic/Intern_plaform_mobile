using People.Data;
using People.Models;
using People.ViewModel;

namespace People.Pages;

public partial class ApplicationDetails : ContentPage
{
	public ApplicationDetails(int studentID)
	{
		InitializeComponent();
		BindingContext = new ApplicationDetailsViewModel(studentID);
	}
}
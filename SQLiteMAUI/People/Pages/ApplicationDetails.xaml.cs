using People.Models;

namespace People.Pages;

public partial class ApplicationDetails : ContentPage
{
	string student;
	public ApplicationDetails(String studentEmail)
	{
		InitializeComponent();
		student = studentEmail;
		lejbl.Text = student;
	}
}
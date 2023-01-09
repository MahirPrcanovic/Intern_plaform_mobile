using People.Data;
using People.Models;
namespace People.Pages;

public partial class ApplicantsPage : ContentPage
{
    public List<Student> StudentList { get; set; }
    PersonRepository repo;
    public ApplicantsPage(PersonRepository prep)
	{
		InitializeComponent();
		userName.Text = "Mahir P.";
        repo = prep;
        StudentList = repo.GetAllStudents();
		BindingContext= this;
	}

    private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniStudent = (Student)myListView.SelectedItem;
        await Navigation.PushModalAsync(new NavigationPage(new ApplicationDetails(odabraniStudent.Email)));
    }
}
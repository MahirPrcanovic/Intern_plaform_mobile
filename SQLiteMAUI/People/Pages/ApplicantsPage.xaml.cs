using People.Models;
namespace People.Pages;

public partial class ApplicantsPage : ContentPage
{
    public IList<Student> StudentList { get; set; }
    public ApplicantsPage()
	{
		InitializeComponent();
		userName.Text = "Mahir P.";
        StudentList = new List<Student> {
           new Student
           {
               
               FirstName="Mahir",
               LastName="Prcanovic",
               Email="mahirprcanovic@gmail.com",
               EducationLevel = "nesto",
               CV = "nesto",
               CoverLetter="Nesto"
           },
           new Student
           {
               
               FirstName="Mahir2",
               LastName="Prcanovic2",
               Email="mahirprcanovic2@gmail.com",
               EducationLevel = "nesto",
               CV = "nesto",
               CoverLetter="Nesto"
           }
        };
		BindingContext= this;
	}

    private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniStudent = (Student)myListView.SelectedItem;
        await Navigation.PushModalAsync(new NavigationPage(new ApplicationDetails(odabraniStudent.Email)));
    }
}
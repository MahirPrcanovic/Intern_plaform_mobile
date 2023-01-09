using People.Models;
namespace People.Pages;

public partial class ApplicantsPage : ContentPage
{
    public IList<Ss> StudentList { get; set; }
    public ApplicantsPage()
	{
		InitializeComponent();
		userName.Text = "Mahir P.";
        StudentList = new List<Ss> {
           new Ss
           {
               
               FirstName="Mahir",
               LastName="Prcanovic",
               Email="mahirprcanovic@gmail.com",
               EducationLevel = "nesto",
               CV = "nesto",
               CoverLetter="Nesto"
           },
           new Ss
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

    private void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        //var myListView = (ListView)sender;
        //var odabranaTura = (Student)myListView.SelectedItem;
        //await Navigation.PushModalAsync(new NavigationPage(new DetaljiTure(registrovanikorisnik, odabranaTura)));
    }
}
using People.Data;
using People.Models;
using People.ViewModel;

namespace People.Pages;

public partial class ApplicantsPage : ContentPage
{
    public List<Student> StudentList { get; set; }
    public ApplicantsPage()
	{
		InitializeComponent();
		userName.Text = "Mahir P.";
        StudentList = App.PersonRepository.GetAllStudents();
		BindingContext= this;
	}

    private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniStudent = (Student)myListView.SelectedItem;
        await Navigation.PushAsync(new ApplicationDetails(odabraniStudent.Id));
    }


}
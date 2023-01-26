using People.ViewModel;

namespace People.Pages;

public partial class SelectionDetailsPage : ContentPage
{
	List<string> Students = new List<string>();
	public SelectionDetailsPage(int selectionID)
	{
		InitializeComponent();
		var students = App.PersonRepository.GetAllStudents();
		for(var i =0; i<students.Count; i++)
		{
			Students.Add(students[i].Email);
        }
		picker.ItemsSource = Students;
        BindingContext = new SelectionDetailsViewModel(selectionID);
	}
}
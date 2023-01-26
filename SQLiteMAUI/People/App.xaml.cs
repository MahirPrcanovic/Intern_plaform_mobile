using People.Data;
using People.Models;

namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepository { get; set; }
    public static UserRepository UserRepository { get; set; }
    public static CommentRepository CommentRepository { get; set; }
    public static User loggedInUser { get; set; }
    public static SelectionRepository SelectionRepository { get; set; }
    public static SelectionStudentRepository SelectionStudentRepository { get; set; }

    public App(PersonRepository repo,UserRepository user,CommentRepository com,SelectionRepository sel, SelectionStudentRepository s)
	{
		InitializeComponent();
		MainPage = new AppShell();
        PersonRepository = repo;
        UserRepository = user;
        CommentRepository = com;
        SelectionRepository = sel;
        SelectionStudentRepository = s;
    }
}

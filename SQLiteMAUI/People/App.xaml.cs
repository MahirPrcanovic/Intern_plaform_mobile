using People.Data;
using People.Models;

namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepository { get; set; }
    public static UserRepository UserRepository { get; set; }
    public static CommentRepository CommentRepository { get; set; }
    public static User loggedInUser { get; set; }
    // TODO: Add a public static PersonRepository property
    /// <summary>
    /// public static PersonRepository PersonRepo { get; set; }
    /// </summary>

    public App(PersonRepository repo,UserRepository user,CommentRepository com)
	{
		InitializeComponent();
		MainPage = new AppShell();
        PersonRepository = repo;
        UserRepository = user;
        CommentRepository = com;
        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        //PersonRepo = repo;

    }
}

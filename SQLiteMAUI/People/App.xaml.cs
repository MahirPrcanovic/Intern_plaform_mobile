using People.Data;

namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepository { get; set; }
    public static UserRepository UserRepository { get; set; }
    // TODO: Add a public static PersonRepository property
    /// <summary>
    /// public static PersonRepository PersonRepo { get; set; }
    /// </summary>

    public App(PersonRepository repo,UserRepository user)
	{
		InitializeComponent();
		MainPage = new AppShell();
        PersonRepository = repo;
        UserRepository = user;
        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        //PersonRepo = repo;

    }
}

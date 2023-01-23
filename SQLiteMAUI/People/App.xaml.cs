using People.Data;

namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepository { get; set; }
    // TODO: Add a public static PersonRepository property
    /// <summary>
    /// public static PersonRepository PersonRepo { get; set; }
    /// </summary>

    public App(PersonRepository repo)
	{
		InitializeComponent();
		MainPage = new AppShell();
        PersonRepository = repo;
        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        //PersonRepo = repo;

    }
}

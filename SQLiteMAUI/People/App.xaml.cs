using People.Data;

namespace People;

public partial class App : Application
{
    // TODO: Add a public static PersonRepository property
    /// <summary>
    /// public static PersonRepository PersonRepo { get; set; }
    /// </summary>

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        //PersonRepo = repo;

    }
}

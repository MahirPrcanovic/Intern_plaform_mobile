using People.Pages;

namespace People;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ApplicantsPage), typeof(ApplicantsPage));
    }
}

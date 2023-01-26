using Microsoft.Maui.Platform;
using People.Pages;

namespace People;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();     
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(ApplicantsPage), typeof(ApplicantsPage));
        Routing.RegisterRoute(nameof(RegisterApplicantPage), typeof(RegisterApplicantPage));
        Routing.RegisterRoute(nameof(ApplicationDetails), typeof(ApplicationDetails));
        Routing.RegisterRoute(nameof(SelectionsPage), typeof(SelectionsPage));
        Routing.RegisterRoute(nameof(AddNewSelectionPage), typeof(AddNewSelectionPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(WelcomeInfoPage), typeof(WelcomeInfoPage));
        Routing.RegisterRoute(nameof(SelectionDetailsPage), typeof(SelectionDetailsPage));

    }
}

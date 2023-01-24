using CommunityToolkit.Maui;
using People.Data;
using People.Pages;
using People.ViewModel;
namespace People;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("SofiaSansSemiCondensed-Black.ttf", "SofiaSans");
			}).UseMauiCommunityToolkit();
		builder.Services.AddSingleton<ApplicationDetailsViewModel>();
		builder.Services.AddSingleton<AddNewSelectionViewModel>();
		builder.Services.AddSingleton<SelectionPageViewModel>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<UserRepository>();
		builder.Services.AddSingleton<PersonRepository>();
		builder.Services.AddSingleton<RegisterApplicantPage>();
		builder.Services.AddSingleton<ApplicantsPage>();
		builder.Services.AddSingleton<ApplicationDetails>();
		builder.Services.AddSingleton<CommentRepository>();
		builder.Services.AddSingleton<SelectionsPage>();
		builder.Services.AddSingleton<SelectionRepository>();
		builder.Services.AddSingleton<AddNewSelectionPage>();
        return builder.Build();
	}
}

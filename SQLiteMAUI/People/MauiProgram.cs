using People.Data;
using People.Pages;

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
			});

		// TODO: Dependency injection - Dodavanej isntance kako bi bila dostupna i moga se koristiti kroz cijelu aplikaciju
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<StudentRepository>();
		builder.Services.AddSingleton<UserRepository>();
		builder.Services.AddTransient<RegisterApplicantPage>();
		builder.Services.AddTransient<ApplicantsPage>();
		builder.Services.AddTransient<ApplicationDetails>();
        return builder.Build();
	}
}

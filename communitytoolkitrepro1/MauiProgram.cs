using CommunityToolkit.Maui;

namespace communitytoolkitrepro1;

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
			})
            .UseMauiCommunityToolkit();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<ComplexDetailPage>();
        builder.Services.AddTransient<ComplexDetailViewModel>();
        builder.Services.AddTransient<PrimitiveDetailPage>();
        builder.Services.AddTransient<PrimitiveDetailViewModel>();

        return builder.Build();
	}
}

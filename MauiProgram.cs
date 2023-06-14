namespace maui_hello_world;

using DotNet.Meteor.HotReload.Plugin;
using maui_hello_world.ViewModels;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
    builder
			.UseMauiApp<App>()
#if DEBUG
    	.EnableHotReload()
#endif
      .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

    builder.Services.AddSingleton<MainPage>();
    builder.Services.AddSingleton<CountViewModel>();

		return builder.Build();
	}
}




using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Tzy.MAUI.AppCenter;

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
			});
		Microsoft.AppCenter.AppCenter.Start("android=9633710e-6bd8-4300-8585-f42e584a421d;" +
                 typeof(Analytics), typeof(Crashes));
        return builder.Build();
	}
}

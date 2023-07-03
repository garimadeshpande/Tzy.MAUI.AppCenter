using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Tzy.MAUI.AppCenter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

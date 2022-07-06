namespace GettingStarted;
using Syncfusion.Maui.DataGrid.Hosting;
using Syncfusion.Maui.Core.Hosting;
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

		builder.ConfigureSyncfusionCore();
		builder.ConfigureSyncfusionDataGrid();
		return builder.Build();
	}
}

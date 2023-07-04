namespace MauiWeek4;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Rekenmachine),typeof(Rekenmachine));
	}
}

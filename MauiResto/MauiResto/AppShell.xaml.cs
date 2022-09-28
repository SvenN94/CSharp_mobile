namespace MauiResto;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AboutPage),typeof(AboutPage));
		Routing.RegisterRoute(nameof(RestaurantPage),typeof(RestaurantPage));
	}
}

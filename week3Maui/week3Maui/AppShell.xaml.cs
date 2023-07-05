namespace week3Maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Progress), typeof(Progress));
		Routing.RegisterRoute(nameof(Editor),typeof(Editor));
		Routing.RegisterRoute(nameof(Switch),typeof(Switch));
		Routing.RegisterRoute(nameof(WebView),typeof(WebView));
		Routing.RegisterRoute(nameof(SearchBar),typeof(SearchBar));
		Routing.RegisterRoute(nameof(DagPicker),typeof(DagPicker));
		Routing.RegisterRoute(nameof(CollectionPage),typeof(CollectionPage));
		Routing.RegisterRoute(nameof(RekenPage),typeof(RekenPage));
	}
}

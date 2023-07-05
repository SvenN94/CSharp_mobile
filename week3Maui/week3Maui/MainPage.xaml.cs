namespace week3Maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	

	private async void BtnSearch_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(SearchBar));
	}

	private async void BtnWebview_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(WebView));
    }

	private async void BtnEditor_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Editor));
    }

	private async void BtnSwitch_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Switch));
    }

	private async void BtnDate_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(DagPicker));
    }

	private async void BtnProgress_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Progress));
	}

	private async void BtnCollectionPage_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(CollectionPage));
	}

	private async void BtnRekenPage_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(RekenPage));
	}
}


namespace MauiRedDevilApp.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
	}

	private async void BtnLogin_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(HomePage));
	}
}
namespace week3Maui;

public partial class Progress : ContentPage
{
	public Progress()
	{
		InitializeComponent();
		BarLoading();
	}

	private async void BarLoading()
	{
		await PgbLoading.ProgressTo(1,500,Easing.Linear);
		
	}
}
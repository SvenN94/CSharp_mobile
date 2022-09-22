namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		count ++;
		if(count % 2 == 0)
		{
			LblColorChange.BackgroundColor = Colors.Yellow;
		}
		else
		{
			LblColorChange.BackgroundColor= Colors.Red;
		}
	}
}


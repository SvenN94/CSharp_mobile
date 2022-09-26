namespace MauiApp2;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
	{

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		string inhoud = TxtInput.Text.ToString();
		LeetTranslator translator = new LeetTranslator();
		LblLeet.Text = translator.ToLeet(inhoud,SldWaarde.Value);
	}
}


namespace PhoneWorld;

public partial class MainPage : ContentPage
{
	string translatedNumber;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Ontranslate(object sender, EventArgs e)
	{
		string enteredNumber = PhonenumberText.Text;
		translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);
		if (!string.IsNullOrEmpty(translatedNumber))
		{
			CallButton.IsEnabled = true;
			CallButton.Text = "Call" + translatedNumber;
		}
		else
		{
			CallButton.IsEnabled=false;
			CallButton.Text = "Call";
		}
	}

	async void CallButton_Clicked(object sender, EventArgs e)
	{
		if (await this.DisplayAlert(
			"Dial a Number",
			"Would you like to call" + translatedNumber + "?",
			"Yes",
			"No"
			))
		{
			try
			{
				if (PhoneDialer.Default.IsSupported)
				{
					PhoneDialer.Default.Open(translatedNumber);
				}
			}
			catch (ArgumentException)
			{

				await DisplayAlert("Unable to dail", "Phone number was not valid.", "OK");
			}
			catch (Exception)
			{
				await DisplayAlert("Unable to dail", "Phone dailing failed.", "OK");
			}

		}
	}
}


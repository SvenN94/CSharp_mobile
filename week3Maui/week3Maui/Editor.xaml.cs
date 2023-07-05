namespace week3Maui;

public partial class Editor : ContentPage
{
	public Editor()
	{
		InitializeComponent();
	}

	private void editor_TextChanged(object sender, TextChangedEventArgs e)
	{
		string oldText = e.OldTextValue;
		string newText = e.NewTextValue;
		string myText = editor.Text;
	}

	 void editor_Completed(object sender, EventArgs e)
	{
		string text = editor.Text;
	}
}
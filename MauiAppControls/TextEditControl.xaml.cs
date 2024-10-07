namespace MauiAppControls;

public partial class TextEditControl : ContentPage
{
	public TextEditControl()
	{
		InitializeComponent();
	}

    private void entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
		entryValueLabel.Text = $"Entry value : {e.NewTextValue}";
    }

    private void editor1_TextChanged(object sender, TextChangedEventArgs e)
    {
		editorValueLabel.Text = $"Editor value : {e.NewTextValue} ";
    }
}
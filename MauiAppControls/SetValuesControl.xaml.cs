namespace MauiAppControls;

public partial class SetValuesControl : ContentPage
{
	public SetValuesControl()
	{
		InitializeComponent();
	}

	private void ckeckbox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		bool isAgree = e.Value;
		/*
		if (isAgree == true)
		{
			DisplayAlert("Agree", "You agree", "OK");
		}
		else
		{
			DisplayAlert("Agree", "You not agree !!", "OK");
		}
		*/
		DisplayAlert("Agree", isAgree ? "You agree" : "You not agree", "Ok");
	}

	private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		//sliderValueLabel.Text = " Slider Value: " + e.NewValue;
		sliderValueLabel.Text = $"Slider Value: {e.NewValue:F0}";

	}

	private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		stepperValueLabel.Text = $"Stepper value : {e.NewValue:F0}";
	}

	private void switch1_Toggled(object sender, ToggledEventArgs e)
	{
		switchValuelabel.Text = e.Value ? "Switch : on" : "Switch : off";
	}

    private void datePicker1_DateSelected(object sender, DateChangedEventArgs e)
    {
		//selectedDateLabel.Text = e.NewDate.ToString("dd/MM/yyyy");
		//selectedDateLabel.Text = "select date : " + e.NewDate.ToString("dd/MM/yyyy");
		selectedDateLabel.Text = $"select date : {e.NewDate:dd/MM/yyyy} ";
    }
}
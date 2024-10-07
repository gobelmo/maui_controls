namespace MauiAppControls;

public partial class IndicatorActivityControl : ContentPage
{
	public IndicatorActivityControl()
	{
		InitializeComponent();
	}

	private void startButton_Clicked(object sender, EventArgs e)
	{
		activityIndicator1.IsRunning = true;
	}

	private void stopButton_Clicked(object sender, EventArgs e)
	{
		activityIndicator1.IsRunning = false;
	}


	double _progress = 0;
	private void Button_Clicked(object sender, EventArgs e)
	{
		_progress = _progress + 0.1;
		if(_progress > 1.0)
		{
			_progress = 0.0;
		}
		progressbar1.Progress = _progress;
		//progressbar1.Progress = 1;
	}
}
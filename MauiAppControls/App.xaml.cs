namespace MauiAppControls;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new InitiateCommandControl();
		//MainPage = new SetValuesControl();
		//MainPage = new TextEditControl();
		MainPage = new IndicatorActivityControl();
	}
}

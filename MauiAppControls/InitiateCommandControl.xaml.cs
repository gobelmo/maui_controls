namespace MauiAppControls;

public partial class InitiateCommandControl : ContentPage
{
	string selectedGrade = "";
	public InitiateCommandControl()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Button Click","Allert message","OK");
    }


    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Button Click","Allert message from image button click","Close");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		var radioButton = (RadioButton)sender;
        if (radioButton.IsChecked)
        {
           selectedGrade = radioButton.Value.ToString() + "";
		   //DisplayAlert("Selected Grade",selectedGrade,"OK");
		   //selectedGradeLabel.Text = "Selected grade : " + selectedGrade;
		   selectedGradeLabel.Text = $"Selected grade : { selectedGrade }";

        }
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		var keyword = searchBar.Text;
		DisplayAlert("Search" , $"Keyword : {keyword} " , "Close");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
		DisplayAlert("Favorite","Add to favorite.","Ok");
    }

    private void SwipeItem_Invoked1(object sender, EventArgs e)
    {
		DisplayAlert("Remove","Remove from favorite.","Ok");
    }
}
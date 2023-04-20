namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnWollosClick(object sender, EventArgs e)
	{
		DisplayAlert("Bonjour", "Wollos", "Ok");
	}

    private async void MoveBtn_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("NewPage2");
    }
}


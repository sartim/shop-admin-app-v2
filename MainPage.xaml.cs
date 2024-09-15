namespace ShopAdmin;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnLoginButtonClicked(object sender, EventArgs e)
	{	
		 Navigation.PushAsync(new MainPage());

		// count++;

		// if (count == 1)
		// 	LogingBtn.Text = $"Clicked {count} time";
		// else
		// 	LogingBtn.Text = $"Clicked {count} times";

		// SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


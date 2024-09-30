namespace ShopAdmin;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		AppShell.SetBackgroundColor(this, Color.FromRgb(0, 152, 225));   
		AppShell.SetTitleColor(this, Color.FromRgb(0, 0, 0));
	}
}

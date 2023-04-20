namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("NewPage2", typeof(NewPage2));

		Routing.RegisterRoute("NewPage3", typeof (NewPage3));

	}
}

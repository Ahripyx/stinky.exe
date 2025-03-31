namespace Stinky;

public partial class NoPage : ContentPage
{
	public NoPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}
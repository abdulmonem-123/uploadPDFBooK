namespace uploadPDFBooK;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnLinkTapped(object sender, EventArgs e)
    {
        // رابط الويب الذي ترغب في فتحه
        var url = "https://www.hpiz.edu.ly/";

        // فتح الرابط في المتصفح
        await Launcher.OpenAsync(url);
    }
}
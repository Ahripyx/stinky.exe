using Plugin.Maui.Audio;

namespace Stinky;

public partial class YesPage : ContentPage
{
    private readonly IAudioManager audioManager;
    private IAudioPlayer player;
    public YesPage(IAudioManager audioManager)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.audioManager = audioManager;
        AudioPlay();
        SwitchImagesAfterDelay();
    }

    private async void AudioPlay()
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("catsing.m4a"));
        player.Loop = true;
        player.Play();
    }

    private async void SwitchImagesAfterDelay()
    {
        await Task.Delay(4500); //4.5 second delay
        var firstImage = this.FindByName<Image>("catHearts");
        firstImage.IsVisible = false;
        catRose.IsVisible = true;
        loveLabel.IsVisible = true;
    }
}
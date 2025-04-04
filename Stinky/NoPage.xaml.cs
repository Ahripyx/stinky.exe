using System.Net;
using Plugin.Maui.Audio;

namespace Stinky;

public partial class NoPage : ContentPage
{
    private readonly IAudioManager audioManager;
    private IAudioPlayer player;
    private IAudioPlayer sadViolin;
    public NoPage(IAudioManager audioManager)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.audioManager = audioManager;
        AudioPlay();
    }


    private async void AudioPlay()
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("catcry.mp3"));
        player.Loop = true;
        player.Play();
        player.Volume = 0.5;

        sadViolin = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sadviolin.mp3"));
        sadViolin.Loop = true;
        sadViolin.Play();
        sadViolin.Volume = 0.5;
    }


    private async void PauseAudio()
    {
        while (player.Volume > 0 && sadViolin.Volume > 0)
        {
            player.Volume -= 0.1;
            sadViolin.Volume -= 0.1;
            await Task.Delay(100);
        }
        player.Pause();
    }

    private async void OnTakeItBackButtonClicked(object sender, EventArgs e)
    {
        PauseAudio();
        Application.Current.MainPage = new NavigationPage(new YesPage(audioManager));
    }
}
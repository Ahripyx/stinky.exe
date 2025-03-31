using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;
using System;
using System.IO;
using System.Reflection;

namespace Stinky
{
    public partial class MainPage : ContentPage
    {
        private readonly IAudioManager audioManager;
        private IAudioPlayer player;

        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            ShowDialog();
            this.audioManager = audioManager;
            AudioPlay();

        }

        private async void AudioPlay()
        {
            player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ClubPenguinPizza.mp3"));
            player.Play();
        }

            
        private async void PauseAudio()
        {
            while (player.Volume > 0)
            {
                player.Volume -= 0.1;
                await Task.Delay(100);
            }
            player.Pause();
        }

        private void ShowDialog()
        {
            dialogOverlay.IsVisible = true;
            dialog.IsVisible = true;
        }

        private void HideDialog()
        {
            dialogOverlay.IsVisible = false;
            dialog.IsVisible = false;
        }
        private async void OnYesButtonClicked(object sender, EventArgs e)
        {
            HideDialog();
            PauseAudio();
            Application.Current.MainPage = new NavigationPage(new YesPage());
        }

        private async void OnNoButtonClicked(object sender, EventArgs e)
        {
            HideDialog();
            PauseAudio();
            Application.Current.MainPage = new NavigationPage(new NoPage());
        }
    }
}
﻿using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;
using System;
using System.IO;
using System.Reflection;

namespace Stinky
{
    public partial class MainPage : ContentPage
    {
        private readonly IAudioManager audioManager;

        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            ShowDialog();
            this.audioManager = audioManager;
            AudioPlay();

        }

        private async void AudioPlay()
        {
            var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ClubPenguinPizza.mp3"));
            player.Play();
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
        private void OnYesButtonClicked(object sender, EventArgs e)
        {
            HideDialog();
        }

        private void OnNoButtonClicked(object sender, EventArgs e)
        {
            HideDialog();
        }
    }
}
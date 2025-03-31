using Plugin.Maui.Audio;

namespace Stinky
{
    public partial class App : Application
    {
        private readonly IAudioManager _audioManager;

        public App(IAudioManager audioManager)
        {
            _audioManager = audioManager;
            InitializeComponent();
        }

        int wndWidth = 800;
        int wndHeight = 600;

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new MainPage(_audioManager))
            {
                Width = wndWidth,
                Height = wndHeight,
                MaximumHeight = wndHeight,
                MaximumWidth = wndWidth,
                MinimumHeight = wndHeight,
                MinimumWidth = wndWidth,
            };

            return window;
        }
    }
}
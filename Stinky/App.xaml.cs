namespace Stinky
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        int wndWidth = 800;
        int wndHeight = 600;

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new MainPage())
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
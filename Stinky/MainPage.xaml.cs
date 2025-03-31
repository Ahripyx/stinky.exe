namespace Stinky
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            ShowDialog();
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
            // Add your logic for the "Yes" button here
        }

        private void OnNoButtonClicked(object sender, EventArgs e)
        {
            HideDialog();
            // Add your logic for the "No" button here
        }
    }

}

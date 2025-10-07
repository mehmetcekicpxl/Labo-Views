namespace LaboViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  async void CardClicked(object sender, TappedEventArgs e)
        {
            Border? borderTapped = sender as Border;

            if (borderTapped is null)
                return;

            if (borderTapped.BackgroundColor == Colors.Black)
                borderTapped.BackgroundColor = Colors.Red;
            else
                borderTapped.BackgroundColor = Colors.Black;

            await borderTapped.RotateYTo(360, 1500);
            borderTapped.RotationY = 0;
        }
    }

}

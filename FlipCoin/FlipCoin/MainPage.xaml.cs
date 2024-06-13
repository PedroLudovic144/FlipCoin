namespace FlipCoin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnFlipCoin_Clicked(System.Object sender, System.EventArgs e)
        {

            string selectedSide = Convert.ToString(PickerDecider.SelectedItem);
            int select = 0;
            if (selectedSide == "Cara")
                select = 1;
            else if (selectedSide == "Coroa")
                select = 2;

            int result = new Random().Next(1, 3);
            if (result == select)
                LblResult.Text = "Acertouuuu";
            else if (result != select)
                LblResult.Text = "Errouuuu";

        }
    }

}

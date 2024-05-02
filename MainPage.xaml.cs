using Microsoft.Maui.Controls;

namespace FlipCoin
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();
        

        private void CoinPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle when the user selects an item in the Picker.
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Simulate flipping a coin
            Random random = new Random();
            int randomNumber = random.Next(2); // 0 ou 1

            // Obter a escolha do usuário
            string selectedOption = coinPicker.SelectedItem?.ToString();

            if (selectedOption != null)
            {
                string result = (randomNumber == 0) ? "Cara" : "Coroa";

                if (selectedOption.Equals("Cara"))
                {
                    coinImage.Source = ("cara.jpeg");
                }
                else
                {
                    coinImage.Source = ("coroa.jpeg");
                }

                if (selectedOption.Equals(result))
                {
                    resultLabel.Text = "Você acertou!";
                }
                else
                {
                    resultLabel.Text = "Você errou!";
                }

                if(result=="Cara"){
                    coinImage.Source = "cara.jpeg";
                 }
                else
                {
                    coinImage.Source = "coroa.jpeg";
                }
            }
            else
            {
                resultLabel.Text = "Por favor, selecione Cara ou Coroa.";
            }
        }
    }
}

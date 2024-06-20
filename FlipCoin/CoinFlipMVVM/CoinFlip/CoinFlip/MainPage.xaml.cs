using System;
using CoinFlip.Models;
using Microsoft.Maui.Controls;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        Coin coin;
        string chosenSide;

        public MainPage()
        {
            InitializeComponent();
            coin = new Coin();
        }

        private void OnCaraClicked(object sender, EventArgs e)
        {
            chosenSide = "cara";
            SelectedCoinImage.Source = "cara.png"; 
        }

        private void OnCoroaClicked(object sender, EventArgs e)
        {
            chosenSide = "coroa";
            SelectedCoinImage.Source = "coroa.png";
        }

        private void OnPlayButtonClicked(object sender, EventArgs e)
        {
            string result = coin.Jogar();
            string resultImageSource = result == "cara" ? "cara.png" : "coroa.png"; 

            ResultLabel.Text = $"Resultado: {result}";
            SelectedCoinImage.Source = resultImageSource;
        }
    }
}

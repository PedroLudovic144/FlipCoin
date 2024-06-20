using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        private void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();
            Imagem = coin.LadoSorteado == "cara" ? "cara_image.png" : "coroa_image.png";

            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "Você venceu!";
            }
            else
            {
                Resultado = "Você perdeu!";
            }
        }
    }
}

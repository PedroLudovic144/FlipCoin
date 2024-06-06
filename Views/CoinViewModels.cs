using CommunityToolkit.Mvvm.ComponentModel;
using FlipCoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin.Views
{
    internal partial class CoinViewModels : ObservableObject

    {
            [ObservableProperty]
            private string resultado;

            [ObservableProperty]
            private string imagem;

            [ObservableProperty]
            private string escolha;

          public void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();
            if (Escolha == coin.LadoEscolido)
            {
                Resultado = Escolha = "Você venceu";
            }
            else
            {
                Resultado = Escolha = "Você perdeu";
            }
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using FlipCoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlipCoin.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        public ICommand JogarCommand { get;}

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            //instanciando uma moeda
            Coin coin = new Coin();

            //jogando uma moeda
            coin.Jogar();

            //comparar a escolha com o resultado
            //Resultado = Escolha == coin.LadoSorteado ? "Parabénssss" : "veio a perder";
            //ou
            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "venceu";
            }
            else
            {
                Resultado = "perdeu";
            }

        }
    }
}

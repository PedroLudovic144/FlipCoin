using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin.Models
{
    internal class Coin
    {
        public string Lado { get; set; }
        public int LadoEscolido { get; set; }
        public Coin()
        {

        }
        public  void Jogar()//string
        {
            Random aleatorio = new Random();
            int randomNumber = aleatorio.Next(2);

        }

    }
}

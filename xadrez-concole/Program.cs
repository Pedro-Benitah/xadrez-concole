using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_concole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.ReadLine();
        }
    }
}

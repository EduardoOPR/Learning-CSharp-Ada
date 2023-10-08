using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula1.Desafio2
{
    internal class Desafio2
    {
        public void CalcIdade()
        {
            int anoAtual, anoNascimento;

            Console.Write("Digite o ano atual em que estamos: ");
            anoAtual = int.Parse(Console.ReadLine());
            Console.Write("Digitie em que você nasceu: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem {anoAtual - anoNascimento} anos");


        }

    }
}

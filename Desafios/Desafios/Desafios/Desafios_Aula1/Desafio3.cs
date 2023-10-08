using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula1.Desafio3
{
    internal class Desafio3
    {
        public void ValorGorjeta()
        {
            int contaTotal, porcentagemGorjeta;
            float gorjeta;

            Console.Write("Insira o valor total da conta do restaurante: ");
            contaTotal = int.Parse(Console.ReadLine());
            Console.Write("Insira a porcentagem de gorjeta da conta (exemplo: 15 ou 20): ");
            porcentagemGorjeta = int.Parse(Console.ReadLine());

            gorjeta = (float)contaTotal * porcentagemGorjeta / 100;

            Console.WriteLine($"\nO valor da gorjeta foi de R${gorjeta} e o total a ser pago é R${contaTotal + gorjeta}");


        }

    }
}
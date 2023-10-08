using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula1.Desafio4
{
    internal class Desafio4
    {
        public void ConverteValores() {
            float real;
            double convDolar = 5.17, convEuro = 5.45;

            Console.Write("Digite um valor em reais (R$): ");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine($"R${real} reais correspondem a: \n{real / convDolar} dolares\n{real / convEuro} euros");
        }
        
    }
}

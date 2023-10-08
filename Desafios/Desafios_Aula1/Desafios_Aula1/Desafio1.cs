using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula1.Desafio1
{
    internal class Desafio1
    {
        public void Operacoes()
        {
            int num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digitie o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados os números {num1} e {num2} temos que:");
            Console.WriteLine($"A sua soma é {num1 + num2}");
            Console.WriteLine($"A sua subtração é {num1 - num2}");
            Console.WriteLine($"A sua multiplicação é {num1 * num2}");
            if (num2 == 0)
            {
                Console.WriteLine($"O segundo número é zero não foi possível realizar a divisão");
            }
            else
            {
                Console.WriteLine($"A sua divisão é {(float)num1 / num2}");
            }

        }

    }
}

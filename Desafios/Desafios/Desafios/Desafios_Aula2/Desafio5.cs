using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula2.Desafio5
{
    internal class Desafio5
    {
        public void MultaPeixe()
        {
            float peso;

            Console.Write("Qual o peso total dos peixes pegos? ");
            peso = float.Parse(Console.ReadLine());

            if (peso > 0)
            {
                if (peso > 51)
                {
                    Console.WriteLine($"For excedido {(peso - 50):f2}KG de peixe, por tanto uma taxa de R$ {((int)peso - 50) * 4} é necessário ser paga");
                }
                else
                {
                    Console.WriteLine("O peso excedido foi de ZERO kg, portanto não há taxa a se pagar");
                }
            }
            else
            {
                Console.WriteLine("Peso invalido");
            }

        }
    }
}

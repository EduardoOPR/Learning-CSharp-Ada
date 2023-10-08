using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula3.Desafio15
{
    internal class Desafio15
    {
        public void readNumbers(){
            int counter = 0, evenCounter = 0;
            double sum = 0;
            bool isZero = false;

            Console.WriteLine("Digite quantos numeros quiser, e 0 para parar");
            do {
                Console.Write($"{counter+1}º Número: ");
                if (double.TryParse(Console.ReadLine(), out double aux) && aux != 0)
                {
                    sum = sum + aux;
                    if (aux % 2 == 0) { evenCounter++; }
                    counter++;
                    continue;
                }
                else {
                    isZero = aux == 0;
                    string message = isZero ? "Resultado Final: \n" : "Número invalido";
                    Console.WriteLine(message);
                }
            } while (!isZero);

            Console.WriteLine($"{counter} Numeros foram digitas\n{sum:f2} Foi o resultado da soma dos números\n{evenCounter} Números pares foram digitados");

        }
    }
}

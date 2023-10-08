using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula3.Desafio13
{
    internal class Desafio13
    {
        public void vectorOperations() {

            int[] integersVector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                bool isInt;
                Console.Write($"Digite o {i+1}º número: ");
                do {
                    isInt = int.TryParse(Console.ReadLine(), out int aux);
                    if (isInt)
                    {
                        integersVector[i] = aux;
                    }
                    else {
                        Console.Write($"Valor inválido\nDigite o {i+1}º número: ");
                    }
                } while (!isInt);
            }
            Console.Clear();
            Console.WriteLine($"Vetor: [{string.Join(", ", integersVector)}]");
            Console.WriteLine($"Média: {integersVector.Average()}\nSoma: {integersVector.Sum()}\nMenor valor: {integersVector.Min()} ");
        }

    }
}

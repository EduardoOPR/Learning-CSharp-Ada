using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula2.Desafio6
{
    internal class Desafio6
    {
        public void ClassificarNadador()
        {
            Console.Write("Digite a idade do nadador: ");

            //Convert.ToInt32 permite aceitar valores nulos.. ps: melhor o TryParse
            int idade = Convert.ToInt32(Console.ReadLine());

            string categoria = Classificador(idade);

            Console.WriteLine($"A categoria do nadador é: {categoria}");

        }

        static string Classificador(int idade)
        {
            string categoria;

            if (idade >= 5 && idade <= 7)
            {
                categoria = "Infantil A";
            }
            else if (idade >= 8 && idade <= 11)
            {
                categoria = "Infantil B";
            }
            else if (idade >= 12 && idade <= 13)
            {
                categoria = "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                categoria = "Juvenil B";
            }
            else
            {
                categoria = "Adultos";
            }

            return categoria;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula2.Desafio8
{
    internal class Desafio8
    {
        public void MediaNotas()
        {
            float nota, media;

            Console.Write("Digite a primeira nota: ");
            nota = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota = nota + float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            nota = nota + float.Parse(Console.ReadLine());

            media = nota / 3;
            if (media > 7)
            {
                Console.WriteLine($"Passou com media {media}");
            }
        }
    }
}

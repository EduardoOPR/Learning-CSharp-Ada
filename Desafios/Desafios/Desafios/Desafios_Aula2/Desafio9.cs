using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula2.Desafio9
{
    internal class Desafio9
    {
        public void Turmas() {
            string escolha;
            Console.WriteLine("C#\nJava\nC++");
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "C#":
                    Console.WriteLine("Voce está matriculado na turma de C#");
                    break;
                case "Java":
                    Console.WriteLine("Voce está matriculado na turma de C#");
                    break;
                case "C++":
                    Console.WriteLine("Voce está matriculado na turma de C#");
                    break;
                default:
                    Console.WriteLine("Curso não existente");
                    break;
            }
        }
    }
}

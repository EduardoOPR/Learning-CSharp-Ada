using Desafios_Aula1.Desafio1;
using Desafios_Aula1.Desafio2;
using Desafios_Aula1.Desafio3;
using Desafios_Aula1.Desafio4;
using Desafios_Aula2.Desafio5;
using Desafios_Aula2.Desafio6;
using Desafios_Aula2.Desafio7;
using Desafios_Aula2.Desafio8;
using Desafios_Aula2.Desafio9;
using Desafios_Aula3.Desafio12;
using Desafios_Aula3.Desafio13;
using Desafios_Aula3.Desafio14;
using Desafios_Aula3.Desafio15;

namespace Desafios_aula1
{
    class DesafiosCSharp
    {
        static void Main(string[] args)
        {
            string? escolha;

            Console.WriteLine("Digite qual dos desafios executar: \n1 - Desafio 1\n2 - Desafio 2\n3 - Desafio 3\n4 - Desafio 4\n5 - Desafio 5\n6 - Desafio 6\n7 - Desafio 7\n8 - Desafio 8\n9 - Desafio 9\n10 - Desafio 10\n11 - Desafio 11\n12 - Desafio 12\n13 - Desafio 13\n14 - Desafio 14\n15 - Desafio 15");
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Desafio1 d1 = new Desafio1();
                    Console.Clear();
                    d1.Operacoes();
                    break;
                case "2":
                    Desafio2 d2 = new Desafio2();
                    Console.Clear();
                    d2.CalcIdade();
                    break;
                case "3":
                    Desafio3 d3 = new Desafio3();
                    Console.Clear();
                    d3.ValorGorjeta();                   
                    break;
                case "4":
                    Desafio4 d4 = new Desafio4();
                    Console.Clear();
                    d4.ConverteValores();
                    break;
                case "5":
                    Desafio5 d5 = new Desafio5();
                    Console.Clear();
                    d5.MultaPeixe();
                    break;
                case "6":
                    Desafio6 d6 = new Desafio6();
                    Console.Clear();
                    d6.ClassificarNadador();
                    break;
                case "7":
                    Desafio7 d7 = new Desafio7();
                    Console.Clear();
                    d7.ProdutosEletronicos();
                    break;
                case "8":
                    Desafio8 d8 = new Desafio8();
                    Console.Clear();
                    d8.MediaNotas();
                    break;
                case "9":
                    Desafio9 d9 = new Desafio9();
                    Console.Clear();
                    d9.Turmas();
                    break;
                case "12":
                    Desafio12 d12 = new Desafio12();
                    Console.Clear();
                    d12.SumVector();
                    break;
                case "13":
                    Desafio13 d13 = new Desafio13();
                    Console.Clear();
                    d13.vectorOperations();
                    break;
                case "14":
                    Desafio14 d14 = new Desafio14();
                    Console.Clear();
                    d14.sum100();
                    break;
                case "15":
                    Desafio15 d15 = new Desafio15();
                    Console.Clear();
                    d15.readNumbers();
                    break;
                default:
                    Console.WriteLine("Valor invalido");
                    break;

            }
        }

    }
}
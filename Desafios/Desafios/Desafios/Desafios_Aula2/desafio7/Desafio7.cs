using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafios_Aula2.Desafio7.Produtos;

namespace Desafios_Aula2.Desafio7
{
    internal class Desafio7
    {
        public void ProdutosEletronicos()
        {
            string codigo;
            double total = 0;
            int unidades;

            //seria mais fácil fazer esse com dictionary, onde a chave seria o código e o valor serio a classe produto

            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto( "0001", 4.99F, "Arroz 1KG"));
            listaProdutos.Add(new Produto( "0002", 7.49F, "Feijão 1KH"));
            listaProdutos.Add(new Produto( "0003", 10.99F, "Coca Cola 2L"));

            Console.WriteLine("Produtos sendo vendidos: ");

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine("\n##########################\n");
                Console.WriteLine(produto.getCodigo);
                Console.WriteLine(produto.getNome);
                Console.WriteLine(produto.getValorUnitario);
            }
            Console.WriteLine("\n##########################\n");
            Console.WriteLine("Escolha o que comprar =D e 0 para finalizar");
            do {
                do
                {
                    Console.Write("Código do produto que queira comprar: ");
                    codigo = Console.ReadLine();
                } while (!listaProdutos.Exists(p => p.getCodigo == codigo) && codigo !="0");
                if(codigo != "0")
                {
                    do
                    {
                        Console.Write("Quantas unidades do produto: ");
                    } while (!int.TryParse(Console.ReadLine(), out unidades));

                    Produto produtoAux = listaProdutos.Find(p => p.getCodigo == codigo);
                    total = total + produtoAux!.getValorUnitario * unidades;
                }
            } while (!(int.Parse(codigo) == 0));

            Console.Write($"A compra deu: R$ {total:f2}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula3.Desafio14
{
    internal class Desafio14
    {
        public void sum100() {
            int sumAux = 0;
            for (int i = 1; i <= 100; i++) { 
                sumAux = sumAux + i;    
            } 
            Console.WriteLine($"A soma de 1 a 100 é: {sumAux}");  
        }
    }
}

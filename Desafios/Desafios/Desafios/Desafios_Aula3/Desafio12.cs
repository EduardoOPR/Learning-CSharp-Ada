using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula3.Desafio12
{
    internal class Desafio12
    {
        public void SumVector()
        {
            //Variável para definir o tamanho do vetor
            int vectorLength = 5;

            double[] vector1 = new double[vectorLength];
            double[] vector2 = new double[vectorLength];

            Console.WriteLine($"[{string.Join(", ", randVector(vector1))}] + \n[{string.Join(", ", randVector(vector2))}] = \n[{string.Join(", ",SumVec(vector1, vector2, vectorLength))}]");
        }

        public double[] randVector(double[] vr1)
        {
            Random random = new Random();
            for( int i = 0; i < vr1.Length; i++)
            {
                vr1[i] = Math.Round(49 * random.NextDouble() + 1, 2);
            }
            return vr1;
        }

        public double[] SumVec(double[] v1, double[] v2, int length) {
            double[] resultVector = new double[length];
            for (int i = 0; i < v1.Length; i++)
            {
                resultVector[i] = Math.Round(v1[i] + v2[v1.Length - 1 - i], 2);
            }
            return resultVector;
        }
    }
}

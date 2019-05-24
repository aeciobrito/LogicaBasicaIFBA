using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Vetor é um arranjo unidimensional
 * Arranjo é uma estrutura de dados homogênea, ordenada e alocada em um único bloco
 * Ele possuí tamanho fixo que pode ser determinado em sua declaração.
 */

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota = new int[4]; //Declaração de um vetor com 4 posições de números inteiros

            //A contagem das posições começa do zero. Por ter 4 posições, será do 0 ao 3
            nota[0] = int.Parse(Console.ReadLine());
            nota[1] = int.Parse(Console.ReadLine());
            nota[2] = int.Parse(Console.ReadLine());
            nota[3] = int.Parse(Console.ReadLine());
        }
    }
}

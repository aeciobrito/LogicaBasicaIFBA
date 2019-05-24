using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Matrizes são arranjos bi dimensionais
 * Arranjo é uma estrutura de dados homogênea, ordenada e alocada em um único bloco
 * Ele possuí tamanho fixo que pode ser determinado em sua declaração.
 */

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4]; //Declaração de uma matriz com 3 linhas e 4 colunas
            //As linhas serão de 0 a 2 e as colunas de 0 a 3


            matriz[0, 0] = 20; //Insere o valor 20 na linha 0 e coluna 0 da matriz
            matriz[2, 3] = 12; //Insere o valor 12 na última linha e última coluna da matriz

            Console.WriteLine(matriz[2, 3] + matriz[0, 0]); //Exibe a soma dos valores inseridos nessas posições
        }
    }
}

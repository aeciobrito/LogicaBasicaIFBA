using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Essa é a estrutura de repetição mais simples que repetirá um código enquanto uma condição for verdadeira
 * Certifique-se que a condição ficará falsa em algum momento, ou terá um looping infinito
 */

namespace RepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0; //variável que será verificada

            while (contador <= 10) //condição a ser testada a cada ciclo de repetição
            {
                Console.WriteLine(contador); //escreve o valor atual do contador
                contador++; //incrementa mais um número no contador
            }
        }
    }
}

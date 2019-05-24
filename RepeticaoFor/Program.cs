using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Estrutura de repetição comumente utilizada
 * Conta com a declaração de um índice que pode ser incrementado ou decrementado e um teste condicional 
 */

namespace RepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador <= 10; contador++) //a variável é declarada diretamente no laço e será incrementada no final de cada ciclo
            {
                Console.WriteLine("O contador está em: " + contador); //escreve o valor atual do contador
            }
        }
    }
}

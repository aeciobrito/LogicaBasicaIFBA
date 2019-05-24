using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Condicionais que verificam lógica booleana simples, com verdadeiro e falso 
 */

namespace CondicionaisBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            if(true) //altere esse valor para true ou false
            {
                Console.WriteLine("Esse valor será exibido se o valor de parâmetro for 'true'");
            }
            else
            {
                Console.WriteLine("Esse valor será exibido se o valor de parâmetro for 'false'");
            }
        }
    }
}

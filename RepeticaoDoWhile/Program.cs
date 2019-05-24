using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Diferente da estrutura while, essa estrutura irá realizar uma ação ao menos uma vez
 * Apoós a execução da ação, um teste será realizado e se a condição for verdadeira, o laço se repetirá mais uma vez
 */

namespace RepeticaoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            do
            {
                Console.WriteLine("Deseja sair do laço de repetição? "); //Essa pergunta será exibida obrigatóriamente ao menos uma vez
                resposta =  Console.ReadLine(); //lê a resposta

            } while (resposta != "sim"); //continuará no laço enquanto a resposta for diferente de "sim"
        }
    }
}

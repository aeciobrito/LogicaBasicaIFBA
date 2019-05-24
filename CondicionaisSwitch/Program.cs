using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Estrutura condicional mais avançada e eficiente o encadeamento de if's
 * Fuciona muito bem em situações que um conjunto de possibilidades pré-definidas é aguardada para uma variável
 */

namespace CondicionaisSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao; //variável para leitura de dados do usuário

            opcao = Console.ReadLine(); //leitura de dados do usuário, que pode informar "a", "b", "c" para acessar respostas

            switch (opcao) //o switch verificará o conteúdo da variável, e caso encontre um caso equivalente exibirá o resultado
            {
                case "a":
                    Console.WriteLine("Você escolheu a primeira opção"); 
                    break;
                case "b":
                    Console.WriteLine("Você escolheu a segunda opção");
                    break;
                case "c":
                    Console.WriteLine("Você escolheu a treciera opção");
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção inválida "); //essa opção será exibida caso o usuário deigite qualquer coisa diferente de "a", "b" ou "c"
                    break;
            }
        }
    }
}

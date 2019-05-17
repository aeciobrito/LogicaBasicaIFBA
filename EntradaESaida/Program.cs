using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Aplicação básica para demonstrar a leitura de escrita de dados 
 */

namespace EntradaESaida
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreve um texto qualquer na tela
            Console.WriteLine("Olá Mundo!");

            //Escreve um texto sem a quebra de linha no final
            Console.Write("Esse texto e");
            Console.Write(" esse texto, aparecerão na mesma linha");

            Console.WriteLine(" Esse também, mas fará uma quebra no final.");

            //Exibe uma pausa no programa e aguarda uma entrada de dados do usuário
            Console.ReadLine(); //o valor digitado pode ser inserido em uma variável
        }
    }
}

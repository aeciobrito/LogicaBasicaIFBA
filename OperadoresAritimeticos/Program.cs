using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Operadores básicos matemáticos de adição, subtração, multiplicação, divisão (+, -, *, /)
 * Também temos um operador que calcula o resto da divisão, chamado de MOD (%)
 */
namespace OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operações simples: ");

            Console.WriteLine(5 + 2);
            Console.WriteLine(5 - 2);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 / 2); //números inteiros, divisão exata e não mostra o resto
            Console.WriteLine(5 % 2); //números inteiros, divisão exata e mostra apenas o resto

            Console.WriteLine();

            //podem também ser utilizados com variáveis
            int idade = 18;
            int ano = 2019;

            Console.WriteLine(ano - idade); //exibe o resultado da subtração

            //o operador de adição também pode ser utilizado como concatenador de texto

            Console.WriteLine("O ano de nascimento é: " + (ano - idade)); //exibe o resultado da subtração concatenando o texto
        }
    }
}

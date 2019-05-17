using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Operadores lógicos são utilizados com comparativos de grandezas ou senteças lógicas
 * Para melhor compreensão dos mesmos, é recomendado o estudo de Tabelas Verdade
 */

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador && ( "e" ou "and" lógico) retorna verdadeiro se todos os parâmetros forem verdadeiros:
            Console.WriteLine(true && true); // verdadeiro
            Console.WriteLine(true && false); // falso
            Console.WriteLine(true && true && true && false ); // falso

            Console.WriteLine();

            //Operador || ("ou" ou "or" lógico) retorna verdadeiro se qualquer parâmetro for verdadeiro
            Console.WriteLine(true || true); // verdadeiro
            Console.WriteLine(true || false); // verdadeiro
            Console.WriteLine(false || false); // falso
            Console.WriteLine(false || false || false || true); // verdadeiro

            Console.WriteLine();

            //Temos também operadores de igualdade que retornam verdadeiro ou falso:
            Console.WriteLine(5 == 5); //verdadeiro
            Console.WriteLine(5 == 9); //falso
            Console.WriteLine(5 != 9); //verdadeiro
            Console.WriteLine(5 != 5); //falso

            //Existem outros diversos tipos de operadores, mas para início de estudos esses são os mais importantes
        }
    }
}

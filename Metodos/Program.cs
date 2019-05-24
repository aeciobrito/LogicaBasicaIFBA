using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Um método é um conjunto de ações ou comportamentos do seu código
 * Eles podem retornar ou receber dados para realizar essas ações
 */

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            InformaHora(); //Chamada do método básico que foi declarado mais abaixo            

            int recebeValor = RetornaNumeroAleatorio(); //Chama método que retorna um valor. Esse valor pode ser exibido ou aramazenado em outra variável
            Console.WriteLine("Número aletaório recebido é: " + recebeValor); //Escreve o resultado recebido


            void InformaHora() //Método simples sem retorno de dados. Declarado como "void" por não retornar nem um tipo de dado
            {
                Console.WriteLine(DateTime.Now); //Retorna data e hora do sistema
            }

            int RetornaNumeroAleatorio() //Método que retorna um dado do tipo inteiro
            {
                Random aleatorio = new Random(); //Cria um objeto gerador de números aleatórios
                return aleatorio.Next(1, 100); //Retorna um número aleatório de 1 a 100, ou conforme os parâmetros inseridos
            }  
        }
    }
}

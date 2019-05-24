using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            EscreveSeuNome("John Cena!"); //Chamada do método passando parâmetros

            Console.WriteLine("Informe dois números para multiplicar: "); //Exibição em tela
            Console.WriteLine(MultiplicaValores(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()))); //Esse código exige uma explicação maior:
            /* Propositalmente criei um código um pouco mais avançado.
             * A linha de código acima escreve em tela o que estiver lá dentro, pois tem um Console.WriteLine()
             * Dentro desse Console.WrhiteLine() foi inserido o método de MultiplicarValores(x,y) que recebe dois números como parâmetros
             * Esses números são escritos pelo usuários como texto do tipo string e precisam ser convertidos, por isso o uso do flat.Parse()
             * Dentro da conversão estão os métodos console.ReadLine() que fazem a leitura do código do usuário.
             * Esse códgio poderia ser visualmente mais simples com o usu de variáveis auxiliares.
             */



            void EscreveSeuNome(string nome) //O método recebe um parâmetro de texto, tipo string
            {
                Console.WriteLine("O seu nome é " + nome); //O próprio método se encarrega de escrever o resultado em tela
            }

            float MultiplicaValores(float multiplicador, float multiplicando) //Método recebe dois diferentes parâmetros
            {
                return multiplicador * multiplicando; //Retorna a multiplicação dos parâmetros recebidos
            }
        }
    }
}

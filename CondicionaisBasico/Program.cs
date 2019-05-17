using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionaisBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostaLiga, respostaAnda; //Decaração das variáveis para ler as respostas do usuário

            Console.WriteLine("Seu carro liga?"); //Escreve a pergunta
            respostaLiga = Console.ReadLine(); //Guarda a resposta na variável           

            if (respostaLiga == "sim") //A primeira condicional verifica a resposta principal
            {
                Console.WriteLine("Seu carro anda?"); //Essa pergunta só será escrita se o carro não ligar
                respostaAnda = Console.ReadLine(); //Guarda a resposta na variável

                if (respostaAnda == "sim") //Análise da segunda resposta
                {
                    Console.WriteLine("Não foram identificados problemas"); //Nesse caso as duas respostas foram "sim"
                }
                else
                {
                    Console.WriteLine("Veículo sem combustível"); //Primeira resposta sim, segunda não. Carro liga e não anda
                }

            }
            else //Condição negativa, o carro nem ligou
            {
                Console.WriteLine("Problemas na bateria!"); //Escreve resultado
            }
        }
    }
}

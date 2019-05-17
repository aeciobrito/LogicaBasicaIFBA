using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A declaração de uma variável é feita usando a sintaxe:
 * TIPO_DE_DADO nomeDaVariavel
 * 
 * Uso de variáveis são essenciais para a criação de aplicações.
 * Elas reservam um enedereço de momória para a aplicação poder trabalhar com os dados.
 */

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de variável para receber texto:
            string nome;

            //Criação de variável para receber números inteiros:
            int idade;

            //Atribuição de valores em variáveis através do sinal de igualdade:
            nome = "Fulano";
            idade = 22;

            //Variável declara e inicializada na mesma linha:
            bool solteiro = true;

            //Declaração de múltiplas variáveis do mesmo tipo:
            float nota1, nota2, nota3, nota4; //também podem ser inicializadas nessa linha
        }
    }
}

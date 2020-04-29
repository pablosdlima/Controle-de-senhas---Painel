using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            int opc;
            int total = 0;
            int tempo = 0;
            char tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("1: Retirar senha");
                Console.WriteLine("2: Atender senha");
                Console.WriteLine("Escolha uma das opções acima: ");
                Console.WriteLine("Senha em atendimento: " + senha);
                opc = int.Parse(Console.ReadLine());
                
                if (opc == 1 )
                {
                    Console.Clear();
                    total += 1; //total de senhas retiradas
                    tempo = total * 5; //tempo previsto
                    Console.WriteLine("Senha retirada!");
                    Console.WriteLine("Senhas restantes: " + total);
                    Console.WriteLine("Tempo estimado para finalização dos atendimentos: " + tempo);
                    Console.WriteLine("Senha em Atendimento: " + senha);
                }
                else if(opc == 2)
                {
                    Console.Clear();
                    total --; //após atender total perde 1
                    tempo = total * 5; //atualiza o tempo
                    senha += 1; //numero da senha em atendimento
                    Console.WriteLine("Senhas restantes: " + total);
                    Console.WriteLine("Tempo estimado para finalização dos atendimentos: " + tempo + " minutos");
                    Console.WriteLine("Senha em Atendimento: " + senha);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                    Console.WriteLine("1: Retirar senha");
                    Console.WriteLine("2: Chamar senha");
                    Console.WriteLine("Escolha uma das opções acima: ");
                    opc = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Pressione s para sair / n para continuar");
                    tecla = char.Parse(Console.ReadLine());
            } while (tecla != 's');

            Console.WriteLine("Até mais ;)");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR I VETOR DE NOMES DE JOGOS
            string[] vetJ = new string[3];

            do
            {
                Console.Clear();
                //MENU
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ░░█ █▀█ █▀▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▄█ █▄█ █▄█ ▄█");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Excluir");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //CADASTRAR NOME NO VETOR
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"Informe o {i + 1}° nome do jogo: ");
                        vetJ[i] = Console.ReadLine();
                    }
                }
                else if (opcao == 2)
                {
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"Posicao: {i} | Nome do jogo: {vetJ[i]}");

                    }

                    Console.WriteLine("Para continuar, pressione a tecla Enter ");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"Informe o jogo que deseja atualizar: ");
                        Console.ReadKey();
                        
                    }
                }
                else if (opcao == 4)
                { 

                }
            } while (true);
        }
    }
}

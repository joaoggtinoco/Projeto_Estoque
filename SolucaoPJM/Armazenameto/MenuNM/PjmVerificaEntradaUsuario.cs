using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armazenamento.MenuNM
{
    internal class PjmVerificaEntradaUsuario
    {
        //Método que verifica e faz o tratamento da entrada da opção do usuário.
        internal static int EntradaOpcaoUsuario()
        {
            while (true)
            {
                int opcao;
                string entrada = Console.ReadLine();
                Console.WriteLine("");
                entrada.Remove(0);

                if (String.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Você não digitou nada.");
                    Console.WriteLine("Digite uma opção.");
                    Console.WriteLine("Tente novamente.");
                    Console.Write("->  ");
                    continue;
                }
                
                try
                {
                opcao = int.Parse(entrada);
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Você digitou: {entrada}");
                    Console.WriteLine("Você precisa digitar o NÚMERO da opção.");
                    Console.WriteLine("Tente novamente");
                    Console.Write("->  ");
                    continue;
                }

                if (opcao < 1 || opcao > 9)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Você digitou: {opcao}");
                    Console.WriteLine("Você precisa digitar uma opção existente.");
                    Console.WriteLine("Tente novamente");
                    Console.Write("->  ");
                    continue;
                }

                return opcao;
            }

        }
    }
}

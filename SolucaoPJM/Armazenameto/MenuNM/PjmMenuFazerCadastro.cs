using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armazenamento.MenuNM
{
    internal class PjmMenuFazerCadastro
    {
        internal static void MenuFazerCadastro()
        {

            int opcao = 0;

            while (opcao != 9)
            {

                Console.Clear();
                Console.WriteLine("   Estoque PJM");
                Console.WriteLine("   Fazer cadastro:");
                Console.WriteLine("");
                Console.WriteLine("1- Cadastrar - Gerente");
                Console.WriteLine("2- Cadastrar - Estoquista");
                Console.WriteLine("3- Voltar ao menu anterior");
                Console.WriteLine("9- Finalizar programa");
                Console.WriteLine("");

                opcao = PjmVerificaEntradaUsuario.EntradaOpcaoUsuario();

                switch (opcao)
                {
                    case 1:
                        // TODO implementar
                        break;

                    case 2:
                        // TODO implementar
                        break;

                    case 3://OK
                        Console.Clear();
                        PjmMenuInicial.MenuInicio();
                        break;

                    case 4://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
                        break;

                    case 5://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
                        break;

                    case 6://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
                        break;

                    case 7://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
                        break;

                    case 8://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
                        break;

                    case 9://OK
                        Console.Clear();
                        Console.WriteLine("Programa finalizado");
                        Console.WriteLine("");
                        break;

                }
            }

        }
    }
}

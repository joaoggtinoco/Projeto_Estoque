
using Armazenamento.FuncionariosNM;

namespace Armazenamento.MenuNM
{
    internal class PjmMenuFazerCadastro<T>
    {
        internal static void MenuFazerCadastro()
        {

            PjmGerente T = new PjmGerente();

            int opcao = 0;

            while (opcao != 9)
            {
                //QUERO CADASTRAR UM USUÁRIO E ARMAZENAR EM UMA LISTA
                Console.WriteLine("Cadastrar gerente:");
                Console.WriteLine("");
                Console.WriteLine("Digite o nome:");
                 Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("1- Fazer Login");
                Console.WriteLine("2- Fazer cadastro");
                Console.WriteLine("9- Finalizar programa");
                Console.WriteLine("");

                opcao = PjmVerificaEntradaUsuario.EntradaOpcaoUsuario();

                switch (opcao)
                {
                    case 1://OK
                        opcao = PjmMenuLogin.MenuSignInCargos();
                        break;

                    case 2:
                        opcao = PjmMenuEscolherCadastro.MenuEscolherCadastro();
                        break;

                    case 3://OK
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine("");
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

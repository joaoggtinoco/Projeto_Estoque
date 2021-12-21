
using Armazenamento.FuncionariosNM;

namespace Armazenamento.MenuNM
{
    internal class PjmMenuFazerCadastro
    {
        internal static void MenuFazerCadastro()
        {

            PjmGerente T = new PjmGerente();

            int opcao = 0;

            while (opcao != 9)
            {

                //QUERO CADASTRAR UM USUÁRIO E ARMAZENAR EM UMA LISTA
                Console.WriteLine("Para fazer o cardastro informe os dados que será pedido.");
                Console.WriteLine("Ou digite 9 para finalizar o programa.");
                Console.Write("Seu nome: ");
                Console.ReadLine();
                Console.Write("Seu cargo: ");
                Console.ReadLine();
                Console.Write("Seu E-mail: ");
                Console.ReadLine();
                Console.Write("E escolha uma senha forte: ");
                Console.ReadLine();
                Console.Write("Confirme sua senha: ");
                Console.ReadLine();

                

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

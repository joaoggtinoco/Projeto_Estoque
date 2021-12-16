
namespace Armazenamento.MenuNM
{
    internal class PjmMenuInicial
    {

        internal static void MenuInicio()
        {

            int opcao = 0;

            while (opcao != 9)
            {

                Console.WriteLine("Seja bem-vindo ao estoque PJM!");
                Console.WriteLine("");
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("");
                Console.WriteLine("1- Fazer Login");
                Console.WriteLine("2- Fazer cadastro");
                Console.WriteLine("9- Finalizar programa");
                Console.WriteLine("");

                opcao = PjmVerificaEntradaUsuario.EntradaOpcaoUsuario();

                switch (opcao)
                {
                    case 1://OK
                        PjmMenuLogin.MenuSignInCargos();
                        break;

                    case 2:
                        PjmMenuFazerCadastro.MenuFazerCadastro();
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

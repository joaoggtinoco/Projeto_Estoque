
namespace Armazenamento.MenuNM
{
    internal class PjmMenuLogin
    {

       

        internal static void MenuSignInCargos()
        {

            int opcao = 0;

            Console.Clear();

            while (opcao != 9) {

                Console.WriteLine("   Estoque PJM");
                Console.WriteLine("   LOGIN:");
                Console.WriteLine("");
                Console.WriteLine("1- Login - Gerente");
                Console.WriteLine("2- Login - Estoquista");
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

                    case 3: //OK
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
                        break;

                }
            }
        }
    }
}


namespace Armazenamento.MenuNM
{
    internal class PjmMenuPrincipal
    {

        //Método que verifica e faz o tratamento da entrada da opção do usuário.
        private int EntradaOpcaoUsuario()
        {
            int opcao = 0;

            while (opcao < 1 || opcao > 4)
            {
                string entrada = Console.ReadLine();
                //Quando o usuário passa um valor inteiro o programa não passa pelo try/catch.
                // TODO Erro em tempo de execução ao digitar um número inteiro 
                try
                {
                    opcao = int.Parse(entrada);
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{entrada} não é uma opção, digite uma opção válida.");
                    Console.WriteLine("");
                }
            }
            return opcao;
        }

        internal void Menu()
        {

            int opcao = 0;

            while (opcao != 4) {

                Console.WriteLine("");
                Console.WriteLine("Seja bem-vindo ao estoque PJM!");
                Console.WriteLine("");
                Console.WriteLine("Informe seu cargo.");
                Console.WriteLine("");
                Console.WriteLine("1 - Gerente");
                Console.WriteLine("2- Estoquista");
                Console.WriteLine("3- Sistema");
                Console.WriteLine("4- Sair");
                Console.WriteLine("");

                opcao = EntradaOpcaoUsuario();



                switch (opcao)
                {
                    case 1:
                        PjmMenuGerente.teste();
                        break;

                    case 2:
                        PjmMenuEstoquista.teste();
                        break;

                    case 3:
                        PjmMenuSistema.teste();
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado");
                        break;

                }
            }
        }
    }
}

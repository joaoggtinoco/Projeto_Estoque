﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armazenamento.MenuNM
{
    internal class PjmMenuEscolherCadastro
    {

        internal static int MenuEscolherCadastro()
        {
            int opcao = 0;
            int opcaoEscolhida;
            Console.Clear();

            while (opcao != 9)
            {

                Console.WriteLine("   Estoque PJM");
                Console.WriteLine("   Fazer cadastro:");
                Console.WriteLine("");
                Console.WriteLine("1- Cadastrar - Gerente");
                Console.WriteLine("2- Cadastrar - Estoquista");
                Console.WriteLine("3- Voltar ao menu anterior");
                Console.WriteLine("9- Finalizar programa");
                Console.WriteLine("");

                opcao = PjmVerificaEntradaUsuario.EntradaOpcaoUsuario();
                opcaoEscolhida = opcao;

                switch (opcao)
                {
                    case 1:
                        Console.Clear();

                        PjmMenuFazerCadastro.MenuFazerCadastro();
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
                        return opcao;

                }
            }
            return opcao;
        }
    }
}

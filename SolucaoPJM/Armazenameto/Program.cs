using Armazenamento.EstoqueNM;
using Armazenamento.MenuNM;

namespace Armazenamento {

    class Program
    {
        static void Main(string[] args)
        {
            //PjmEstoque estoque = new PjmEstoque("Bloco 01", 3);

            ////Instanciando categoria
            //PjmCategoriaEstoque catCelulares = new PjmCategoriaEstoque("Celular", 10);
            //PjmProduto celular = new PjmProduto("Samsung", 1200);
            //PjmProduto celular2 = new PjmProduto("Apple", 10000);

            //PjmCategoriaEstoque catComputadores = new PjmCategoriaEstoque("Computador", 10);
            //PjmProduto computador = new PjmProduto("Dell", 6500);
            //PjmProduto computador2 = new PjmProduto("Lenovo", 5000);

            //PjmCategoriaEstoque catNotebooks = new PjmCategoriaEstoque("Notebook", 10);
            //PjmProduto notebook = new PjmProduto("Positivo", 3400);
            //PjmProduto notebook2 = new PjmProduto("Mac", 20000);
            PjmMenuPrincipal menu = new PjmMenuPrincipal();

            menu.Menu();
            




        }
    }
}
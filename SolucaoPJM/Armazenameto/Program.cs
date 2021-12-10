using Armazenamento.EstoqueNM;

namespace Armazenamento {

    class Program
{
        static void Main(string[] args)
        {
            PjmEstoque estoque = new PjmEstoque("Bloco01", 3);

            //Instanciando categoria
            PjmCategoriaEstoque catCelulares = new PjmCategoriaEstoque("Celular", 10);
            PjmProduto celular = new ("Samsung", 1200);
            PjmProduto celular2 = new ("Apple", 10000);

            PjmCategoriaEstoque catComputadores = new PjmCategoriaEstoque("Computador", 10);
            PjmProduto computador = new("Dell", 6500);
            PjmProduto computador2 = new("Lenovo", 5000);

            PjmCategoriaEstoque catNotebooks = new PjmCategoriaEstoque("Notebook", 10);
            PjmProduto notebook = new("Positivo", 3400);
            PjmProduto notebook2 = new("Mac", 20000);

            estoque.ListaVaziah();

            estoque.AdicionarItem(catCelulares);
            estoque.AdicionarItem(catComputadores);
            estoque.AdicionarItem(catNotebooks);

            catCelulares.AdicionarItem(celular);
            catCelulares.AdicionarItem(celular2);

            catComputadores.AdicionarItem(computador);
            catComputadores.AdicionarItem(computador2);

            catNotebooks.AdicionarItem(notebook);
            catNotebooks.AdicionarItem(notebook2);

            estoque.ExibirItens();

            catCelulares.ExibirItens();
            catComputadores.ExibirItens(); 
            catNotebooks.ExibirItens();




        }
    }
}
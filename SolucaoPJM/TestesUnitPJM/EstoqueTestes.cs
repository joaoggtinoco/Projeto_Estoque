using Armazenameto;
using Armazenameto.EstoqueNM;

namespace TestesUnitPJM
{
    class EstoqueTestes
    {
        public void Teste()
        {
            Estoque estoque = new("Bloco01", 3);

            CategoriaEstoque catCelulares = new CategoriaEstoque("Celular", 10);
            Produto celular = new("Samsung", 1200);
            Produto celular2 = new("Apple", 10000);

            CategoriaEstoque catComputadores = new CategoriaEstoque("Computador", 10);
            Produto computador = new("Dell", 6500);
            Produto computador2 = new("Lenovo", 5000);

            CategoriaEstoque catNotebooks = new CategoriaEstoque("Notebook", 10);
            Produto notebook = new("Positivo", 3400);
            Produto notebook2 = new("Mac", 20000);

            estoque.AdicionarCategoria(catCelulares);
            estoque.AdicionarCategoria(catComputadores);
            estoque.AdicionarCategoria(catNotebooks);

            catCelulares.AdicionarProduto(celular);
            catCelulares.AdicionarProduto(celular2);

            catComputadores.AdicionarProduto(computador);
            catComputadores.AdicionarProduto(computador2);

            catNotebooks.AdicionarProduto(notebook);
            catNotebooks.AdicionarProduto(notebook2);

            estoque.ExibirCategoriasDoEstoque();

            catCelulares.ExibirProdutosNaCategoria();
            catComputadores.ExibirProdutosNaCategoria();
            catNotebooks.ExibirProdutosNaCategoria();
        }
    }
}

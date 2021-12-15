using Armazenamento.BaseNM;

namespace Armazenamento.EstoqueNM
{
    public class PjmCategoriaEstoque : PjmCrudBase
    {

        //Construtor
        public PjmCategoriaEstoque() { }
     
        public PjmCategoriaEstoque(string nomeCategoria, int qtdMaxProdutos)
        {
            NomeEntidade = nomeCategoria;
            QtdMaxLista = qtdMaxProdutos;
            list.Capacity = QtdMaxLista;
            Console.WriteLine($"Categoria {nomeCategoria} criada com capacidade de {qtdMaxProdutos} produtos");
        }
    }
}

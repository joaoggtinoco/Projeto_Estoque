using Armazenamento.Base;

namespace Armazenamento.EstoqueNM
{
    public class PjmCategoriaEstoque : PjmCrudBase
  {
        public string Nome { get; set; }
        public int QtdMaxProdutos { get; set; }

        List<PjmProduto> listaDeCategoria;

        //Construtor

        public PjmCategoriaEstoque()
        {

        }

        public PjmCategoriaEstoque(string nome, int qtdMaxProdutos)
        {
            listaDeCategoria = new List<PjmProduto>();
            Nome = nome;
            QtdMaxProdutos = qtdMaxProdutos;
            listaDeCategoria.Capacity = QtdMaxProdutos;
        }

        


        // cRud Mostra todos os produtos na categoria
        public void ExibirProdutosNaCategoria()
        {
            if (categoriaVaziah())
            {
                Console.WriteLine("Não há produtos nessa categoria.");
            }
            else
            {
                foreach (PjmProduto produto in listaDeCategoria)
                {
                    Console.WriteLine("|" + produto.Id + "|" + produto.Nome + "|" + produto.Valor + "|");
                }

            }
        }

        //cruD Remove um produto da categoria
        public void RemoverDaCategoria(PjmProduto produtoParaRemover)
        {
            if (categoriaVaziah())
            {
                Console.WriteLine("Não há produtos para remover.");
            }
            else
            {
                foreach (PjmProduto produto in listaDeCategoria)
                {
                    if (produtoParaRemover == produto)
                    {
                        listaDeCategoria.Remove(produtoParaRemover);
                        Console.WriteLine(produtoParaRemover.Nome + " removido com sucesso");
                        break;
                    }
                }
            }
        }


    }
}

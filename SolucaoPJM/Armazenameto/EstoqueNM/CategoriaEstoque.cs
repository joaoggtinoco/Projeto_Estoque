
namespace Armazenamento.EstoqueNM
{
    public class CategoriaEstoque
    {
        public string Nome { get; set; }
        public int QtdMaxProdutos { get; set; }

        List<Produto> listaDeCategoria;

        //Construtor

        public CategoriaEstoque()
        {

        }

        public CategoriaEstoque(string nome, int qtdMaxProdutos)
        {
            listaDeCategoria = new List<Produto>();
            Nome = nome;
            QtdMaxProdutos = qtdMaxProdutos;
            listaDeCategoria.Capacity = QtdMaxProdutos;
        }

        //Verifica se a categoria esta vazia
        public bool categoriaVaziah()
        {
            if (listaDeCategoria.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        //Verifica se a categoria esta cheia
        public bool categoriaCheiah()
        {
            if (listaDeCategoria.Count.Equals(listaDeCategoria.Capacity))
            {
                return true;
            }
            return false;
        }

        // Crud Adiciona um produto na categoria
        public void AdicionarProduto(Produto produto)
        {
            if (categoriaCheiah())
            {
                Console.WriteLine("Desculpa mas a categoria já está cheia.");
            }
            else
            {
                listaDeCategoria.Add(produto);
                Console.WriteLine(produto.Nome + " adicionado com sucesso");
            }

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
                foreach (Produto produto in listaDeCategoria)
                {
                    Console.WriteLine("|" + produto.Id + "|" + produto.Nome + "|" + produto.Valor + "|");
                }

            }
        }

        //cruD Remove um produto da categoria
        public void RemoverDaCategoria(Produto produtoParaRemover)
        {
            if (categoriaVaziah())
            {
                Console.WriteLine("Não há produtos para remover.");
            }
            else
            {
                foreach (Produto produto in listaDeCategoria)
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

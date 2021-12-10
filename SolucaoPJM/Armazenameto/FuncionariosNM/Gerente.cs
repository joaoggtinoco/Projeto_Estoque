
using Armazenamento.EstoqueNM;

namespace Armazenamento.FuncionariosNM
{
    public class Gerente : Funcionario
    {

        private Estoque estoque;

        //Metodos para criar e apagar um estoque
        public bool CriarEstoque(string nomeEstoque, int capacidadeEstoque)
        {
            estoque = new Estoque (nomeEstoque, capacidadeEstoque);

            return true;
        }

        public bool ApagarEstoque(Estoque estoqueParaApagar)
        {
            estoqueParaApagar = null;

            return true;
        }

        //Metódos CRUD para categoria
        public bool AdicionarCategoria(CategoriaEstoque categoria)
        {
            estoque.AdicionarCategoria(categoria);

            return true;
        }

        public override string RemoverCategoria(CategoriaEstoque categoria)
        {
            return base.RemoverCategoria(categoria);
        }

        public override string EditarCategoria(CategoriaEstoque categoria)
        {
            return base.EditarCategoria(categoria);
        }
        public override string VerTodasCategorias(CategoriaEstoque categoria)
        {
            throw new NotImplementedException();
        }

        //Métodos CRUD para produto
        public override string AdicionarProduto(Produto produto)
        {
            return base.AdicionarProduto(produto);
        }

        public override string RemoverProduto(Produto produto)
        {
            return base.RemoverProduto(produto);
        }
        public override string EditarProduto(Produto produto)
        {
            return base.EditarProduto(produto);
        }

        public override string VerTodosProdutos(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}

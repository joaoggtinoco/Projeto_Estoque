
using Armazenamento.EstoqueNM;

namespace Armazenamento.FuncionariosNM
{
    public class PjmGerente : PjmFuncionario
    {

        public PjmGerente()
        {

        }

        public PjmGerente(string nomeGeren, string cargoGeren, string emailGeren, string senhaGeren)
            : base(nomeGeren, cargoGeren, emailGeren, senhaGeren)
        {
         
        }


        public PjmEstoque estoque;
        public PjmCategoriaEstoque categoria;

        //Metodos para criar e apagar um estoque
        public bool CriarEstoque(string nomeEstoque, int capacidadeEstoque)
        {
            estoque = new PjmEstoque(nomeEstoque, capacidadeEstoque);

            return true;
        }

        // TODO Revisar o código e implementar a lógica.
        //public bool ApagarEstoque(PjmEstoque estoqueParaApagar)
        //{
        //    estoqueParaApagar = null;

        //    return true;
        //}

        //Metódos criar e apagar uma categoria 
        public bool CriarCategoria(string nomeCategoria, int capacidadeProdutos)
        {
            categoria = new PjmCategoriaEstoque(nomeCategoria, capacidadeProdutos);

            return true;
        }

        // TODO Revisar o código e implementar a lógica.
        //public bool CategoriaEstoque(PjmCategoriaEstoque categoriaParaApagar)
        //{
        //    categoriaParaApagar = null;

        //    return true;
        //}


        //Metódos CRUD para categoria 

        public bool AdicionarCategoria(PjmCategoriaEstoque categoria) //@@
        {
            estoque.AdicionarNaLista(categoria);
            return true;
        }

        public bool RemoverCategoria(PjmCategoriaEstoque categoria)
        {
            estoque.RemoverObjeto(categoria);
            return true;
        }

        public void EditarCategoria(PjmCategoriaEstoque categoria)
        {
            //Falta implementar metodos de busca categoria dentro do estoque no PjmCrudBase.cs
        }


        public override void VerTodasCategorias() //@@
        {
            estoque.ExibirLista();
        }

        //Métodos CRUD para produto
        public override bool AdicionarProduto(PjmProduto produto)//@@
        {
            categoria.AdicionarNaLista(produto);

            return true;
        }

        public override bool RemoverProduto(PjmProduto produto)//@@
        {
            categoria.RemoverObjeto(produto);
            return true;
        }

        public override void EditarProduto(PjmProduto produto, PjmCategoriaEstoque categoria)
        {
            //Falta implementar metodos de busca produto dentro das categoria no PjmCrudBase.cs
        }

        public override void VerTodosProdutos() //@@
        {
            categoria.ExibirLista();
        }
    }
}

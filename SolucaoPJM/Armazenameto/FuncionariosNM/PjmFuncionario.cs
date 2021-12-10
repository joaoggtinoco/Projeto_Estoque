using Armazenamento.Base;
using Armazenamento.EstoqueNM;

namespace Armazenamento.FuncionariosNM
{
    public abstract class PjmFuncionario : PjmCrudBase
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }




        //Metódo ver categorias para todos os funcionários
        public abstract void VerTodasCategorias();

        //Métodos CRUD para produto para todos os funcionários
        public abstract bool AdicionarProduto(PjmProduto produto);
        public abstract bool RemoverProduto(PjmProduto produto);
        public abstract void EditarProduto(PjmProduto produto, PjmCategoriaEstoque categoria);
        public abstract void VerTodosProdutos();



    }
}

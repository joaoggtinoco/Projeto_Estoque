using Armazenamento.EstoqueNM;

namespace Armazenamento.FuncionariosNM
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }


 

        //Metódo ver categorias 
        public abstract void VerTodasCategorias(CategoriaEstoque categoria);

        //Métodos CRUD para produto
        public abstract bool AdicionarProduto(Produto produto);
        public abstract bool RemoverProduto(Produto produto);
        public abstract void EditarProduto(Produto produto);
        public abstract void VerTodosProdutos(Produto produto);

    

    }
}

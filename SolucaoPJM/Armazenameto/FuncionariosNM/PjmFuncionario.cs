using Armazenamento.BaseNM;
using Armazenamento.EstoqueNM;

namespace Armazenamento.FuncionariosNM
{
    public abstract class PjmFuncionario
    {

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        internal List<PjmFuncionario> funcionarios = new List<PjmFuncionario>();

        public PjmFuncionario()
        {

        }

        public PjmFuncionario(string nomeFunc, string cargoFunc, string emailFunc, string senhaFunc)
        {
            Nome = nomeFunc;
            Cargo = cargoFunc;
            Email = emailFunc;
            Senha = senhaFunc;
            funcionarios.Add(this);
        }

        //Metódo ver categorias para todos os funcionários
        public abstract void VerTodasCategorias();

        //Métodos CRUD para produto para todos os funcionários
        public abstract bool AdicionarProduto(PjmProduto produto);
        public abstract bool RemoverProduto(PjmProduto produto);
        public abstract void EditarProduto(PjmProduto produto, PjmCategoriaEstoque categoria);
        public abstract void VerTodosProdutos();



    }
}

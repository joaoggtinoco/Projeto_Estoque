

namespace Armazenamento.EstoqueNM
{
     public class Estoque
    {
        public string Nome { get; set; }
        public int QtdMaxCategorias { get; set; }
        public int ContadorDeCategorias { get; set; }

        public List<CategoriaEstoque> listaDoEstoque;

        //Construtor

        public Estoque()
        {
         
        }

        public Estoque(string nome, int qtdMaxCategorias)
        {
            listaDoEstoque = new List<CategoriaEstoque>();
            Nome = nome;
            QtdMaxCategorias = qtdMaxCategorias;
            listaDoEstoque.Capacity = QtdMaxCategorias;
        }


        //Verifica se o estoque esta vazio
        public bool estoqueVazioh()
        {
           if(listaDoEstoque.Count.Equals(0))
            {
                return true;
            }
           return false;
        }

        //Verifica se o estoque esta cheio
        public bool estoqueCheioh()
        {
            if (listaDoEstoque.Count.Equals(listaDoEstoque.Capacity))
            {
                return true;
            }
            return false;
        }

        // Crud Adiciona um produto no estoque
        public void AdicionarCategoria(CategoriaEstoque categoria)
        {
            if (estoqueCheioh())
            {
                Console.WriteLine("Desculpa mas o estoque já está cheio.");
            }
            else
            {
                listaDoEstoque.Add(categoria);
                ContadorDeCategorias++;
                Console.WriteLine("Categoria " + categoria.Nome + " adicionada com sucesso");
            }
        
        }

        // cRud Mostra todos os produtos no estoque
       public void ExibirCategoriasDoEstoque()
        {
            if (estoqueVazioh())
            {
                Console.WriteLine("Não há categorias cadastrados.");
            }
            else
            {
                foreach(CategoriaEstoque categoria in listaDoEstoque)
                    {      
                        Console.WriteLine(" | " + categoria.Nome + " | ");
                    }

            }
        }

        //cruD Remove um produto do estoque 
        public void RemoverCategoria(CategoriaEstoque categoriaParaRemover)
        {
            if(estoqueVazioh())
            {
                Console.WriteLine("Não há categoria para remover.");
            }
            else
            {
                foreach(CategoriaEstoque categoria in listaDoEstoque)
                {
                    if(categoriaParaRemover == categoria)
                    { 
                        listaDoEstoque.Remove(categoriaParaRemover);
                        Console.WriteLine("Categoria " + categoriaParaRemover.Nome + " removida com sucesso");
                        break;
                    }            
                }
            }
        }
     }
}

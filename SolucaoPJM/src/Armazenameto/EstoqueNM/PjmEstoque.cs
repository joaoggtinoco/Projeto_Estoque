using Armazenamento.Base;

namespace Armazenamento.EstoqueNM
{
     public class PjmEstoque : PjmCrudBase
  {
        public string Nome { get; set; }
        public int QtdMaxCategorias { get; set; }
        public int ContadorDeCategorias { get; set; }

        //Construtor

        public PjmEstoque()
        {
         
        }

        public PjmEstoque(string nome, int qtdMaxCategorias)
        {
    
            Nome = nome;
            QtdMaxCategorias = qtdMaxCategorias;
            list.Capacity = QtdMaxCategorias;
        }


        //Verifica se o estoque esta vazio
        public bool estoqueVazioh()
        {
           if(list.Count.Equals(0))
            {
                return true;
            }
           return false;
        }

        //Verifica se o estoque esta cheio
        public bool estoqueCheioh()
        {
            if (list.Count.Equals(list.Capacity))
            {
                return true;
            }
            return false;
        }

        // Crud Adiciona um produto no estoque
        public void AdicionarCategoria(PjmCategoriaEstoque categoria)
        {
            if (estoqueCheioh())
            {
                Console.WriteLine("Desculpa mas o estoque já está cheio.");
            }
            else
            {
                list.Add(categoria);
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
                foreach(PjmCategoriaEstoque categoria in list)
                    {      
                        Console.WriteLine(" | " + categoria.Nome + " | ");
                    }

            }
        }

        //cruD Remove um produto do estoque 
        public void RemoverCategoria(PjmCategoriaEstoque categoriaParaRemover)
        {
            if(estoqueVazioh())
            {
                Console.WriteLine("Não há categoria para remover.");
            }
            else
            {
                foreach(PjmCategoriaEstoque categoria in listaDoEstoque)
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

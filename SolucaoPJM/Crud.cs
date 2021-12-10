using System;

namespace Armazenameto
{
    class Crud
    {     

        public string NomeObjeto { get; set; }
        public int QtdMaxObjetos { get; set; }

        var lista;

        //Construtor CategoriaEstoque
        public CategoriaEstoque(string nomeObjeto, int qtdMaxObjetos, CategoriaEstoque categoria)
        {
            lista = new List<Produto>();
            NomeObjeto = nomeObjeto;
            QtdMaxObjetos = qtdMaxObjetos;
            lista.Capacity = QtdMaxObjetos;
        }

        //Construtor Estoque
        public CategoriaEstoque(string nomeObjeto, int qtdMaxObjetos, Estoque estoque)
        {
            lista = new List<CategoriaEstoque>();
            NomeObjeto = nomeObjeto;
            QtdMaxObjetos = qtdMaxObjetos;
            lista.Capacity = QtdMaxObjetos;
        }

        //Verifica se a lista esta vazia
        public bool EstaVaziah()
        {
            if (lista.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        //Verifica se a lista esta cheia
        public bool EstaCheiah()
        {
            if (lista.Count.Equals(lista.Capacity))
            {
                return true;
            }
            return false;
        }

        // Crud Adiciona um objeto na lista
        public void AdicionarProduto(var objeto)
        {
            if (EstaCheiah())
            {
                Console.WriteLine("Desculpa mas a categoria já está cheia.");
            }
            else
            {
                lista.Add(objeto);
                Console.WriteLine(objeto.Nome + " adicionado com sucesso");
            }

        }

        // cRud Mostra todos os produtos na categoria
        public void ExibirProdutosNaCategoria()
        {
            if (EstaVaziah())
            {
                Console.WriteLine("Não há produtos nessa categoria.");
            }
            else
            {
                foreach (var objeto in lista)
                {
                    Console.WriteLine(objeto.Nome);
                }

            }
        }

        //cruD Remove um produto da categoria
        public void RemoverDaCategoria(var objetoParaRemover)
        {
            if (EstaVaziah())
            {
                Console.WriteLine("Não há produtos para remover.");
            }
            else
            {
                foreach (var objeto in lista)
                {
                    if (objetoParaRemover == objeto)
                    {
                        lista.Remove(objetoParaRemover);
                        Console.WriteLine(objetoParaRemover.Nome + " removido com sucesso");
                        break;
                    }
                }
            }
        }


    }
}

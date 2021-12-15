using Armazenamento.BaseNM;

namespace Armazenamento.EstoqueNM
{
     public class PjmEstoque : PjmCrudBase
  {   

        //Construtor
        public PjmEstoque() { }

        public PjmEstoque(string nomeEstoque, int qtdMaxCategorias)
        {
            NomeEntidade = nomeEstoque;
            QtdMaxLista = qtdMaxCategorias;
            list.Capacity = QtdMaxLista;
            Console.WriteLine($"Estoque {NomeEntidade} criado");
        }
     }
}

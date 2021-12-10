using Armazenamento.Base;
namespace Armazenamento
{
     public class PjmProduto : PjmItemBase
  {
        
        public int Id { get; private set; }
        public double Valor { get; set; }

        public PjmProduto()
        {
      
        }

        public PjmProduto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
            Id++;
        }
    }
}

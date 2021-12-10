using Armazenamento.Base;
namespace Armazenamento
{
     public class PjmProduto : PjmItemBase
  {
       
        public double Valor { get; set; }

        public PjmProduto()
        {
      
        }

        public PjmProduto(string nomeProduto, double valor)
        {
            Nome = nomeProduto;
            Valor = valor;
            Console.WriteLine($"Produto {nomeProduto} criado com valor de R${valor}");
        }
    }
}


namespace Armazenamento
{
     public class Produto
    {
        public string Nome { get; set; }
        public int Id { get; private set; }
        public double Valor { get; set; }

        public Produto()
        {
      
        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
            Id++;
        }
    }
}

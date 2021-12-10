namespace Armazenamento.Base
{
    public class PjmCrudBase : PjmItemBase
    {
        protected List<PjmItemBase> list = new List<PjmItemBase>();

        //Verifica se a categoria esta vazia
        public bool categoriaVaziah()
        {
            if (list.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        //Verifica se a categoria esta cheia
        public bool categoriaCheiah()
        {
            if (list.Count.Equals(list.Capacity))
            {
                return true;
            }
            return false;
        }

        public void AdicionarItem(PjmItemBase item)
        {
            if (categoriaCheiah())
            {
                Console.WriteLine($"Desculpa mas a {item.NomeEntidade} já está cheia.");
            }
            else
            {
                list.Add(item);
                Console.WriteLine(item.Nome + " adicionado com sucesso");
            }


            // cRud Mostra todos os produtos na categoria
            public void ExibirProdutosNaCategoria()
            {
                if (categoriaVaziah())
                {
                    Console.WriteLine("Não há produtos nessa categoria.");
                }
                else
                {
                    foreach (PjmProduto produto in listaDeCategoria)
                    {
                        Console.WriteLine("|" + produto.Id + "|" + produto.Nome + "|" + produto.Valor + "|");
                    }

                }
            }

        }
    }
}
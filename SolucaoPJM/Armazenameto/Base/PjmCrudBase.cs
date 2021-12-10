namespace Armazenamento.Base
{
    public class PjmCrudBase : PjmItemBase
    {
        protected List<PjmItemBase> list = new List<PjmItemBase>();

        //Verifica se a categoria esta vazia
        public bool ListaVaziah()
        {
            if (list.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        //Verifica se a categoria esta cheia
        public bool ListaCheiah()
        {
            if (list.Count.Equals(list.Capacity))
            {
                return true;
            }
            return false;
        }

        public void AdicionarItem(PjmItemBase item)
        {
            if (ListaCheiah())
            {
                Console.WriteLine($"Desculpa mas a {item.NomeEntidade} já está cheia.");
            }
            else
            {
                list.Add(item);
                ContadorDeItens++;

                //Revisar
                if (item.Nome != null)
                {
                    Console.WriteLine($"{item.Nome} adicionado aa {item.NomeEntidade} com sucesso");
                }
                else
                {
                    Console.WriteLine($"{item.NomeEntidade} adicionado a {item.NomeEntidade} com sucesso");
                }
            }
        }

        // cRud Mostra todos os produtos na categoria
        public void ExibirItens()
        {
            if (ListaVaziah())
            {
                Console.WriteLine("Não há produtos nessa categoria.");
            }
            else
            {
                foreach (PjmItemBase item in list)
                {
                    Console.WriteLine("|" + item.Nome + "|");
                }

            }
        }

        //cruD Remove um produto do estoque 
        public void RemoverItem(PjmItemBase itemParaRemover)
        {
            if (ListaVaziah())
            {
                Console.WriteLine("Não há categoria para remover.");
            }
            else
            {
                foreach (PjmItemBase item in list)
                {
                    if (itemParaRemover == item)
                    {
                        list.Remove(itemParaRemover);
                        ContadorDeItens--;
                        Console.WriteLine("Categoria " + item.Nome + " removida com sucesso");
                        break;
                    }
                }
            }
        }
    }
}
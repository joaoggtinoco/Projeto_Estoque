namespace Armazenamento.BaseNM
{
    public class PjmCrudBase : PjmObjetoBase
    {
        protected int ContadorDeObjetos { get; set; }
        protected int QtdMaxLista { get; set; }

        protected List<PjmObjetoBase> list = new List<PjmObjetoBase>();

        //Verifica se a lista esta vazia
        internal bool ListaVaziah()
        {
            if (list.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

        //Verifica se a lista esta cheia
        internal bool ListaCheiah()
        {
            if (list.Count.Equals(list.Capacity))
            {
                return true;
            }
            return false;
        }

        internal void AdicionarNaLista(PjmObjetoBase objeto)
        {
            if (ListaCheiah())
            {
                Console.WriteLine($"Desculpa mas a lista {objeto.NomeEntidade} já está cheia.");
            }
            else
            {
                list.Add(objeto);
                ContadorDeObjetos++;
            }
        }

        // cRud Mostra todos os produtos da lista 
        internal void ExibirLista()
        {
            if (ListaVaziah())
            {
                Console.WriteLine("Não há nada nessa lista.");
            }
            else
            {
                foreach (PjmObjetoBase objeto in list)
                {
                    Console.WriteLine("|" + objeto.Nome + "|");
                }

            }
        }

        //cruD Remove um objeto da lista
        internal void RemoverObjeto(PjmObjetoBase objetoParaRemover)
        {
            if (ListaVaziah())
            {
                Console.WriteLine("Não há nada para remover.");
            }
            else
            {
                foreach (PjmObjetoBase objeto in list)
                {
                    if (objetoParaRemover.Equals(objeto))
                    {
                        list.Remove(objetoParaRemover);
                        ContadorDeObjetos--;
                        Console.WriteLine($" {objeto.Nome} removido da lista com sucesso.");
                        break;
                    }
                }
            }
        }
    }
}
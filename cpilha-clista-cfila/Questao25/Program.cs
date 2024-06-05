namespace Questao25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    internal class Celula
    {
        public Object Item;
        public Celula Prox;
        public Celula()
        {
            Item = null;
            Prox = null;
        }
        public Celula(Object valorItem)
        {
            Item = valorItem;
            Prox = null;
        }
        public Celula(Object valorItem, Celula valorProx)
        {
            Item = valorItem;
            Prox = valorProx;
        }
    }
    internal class CLista
    {
        private Celula primeira;
        private Celula ultima;
        private int qtde;
        public CLista()
        {
            primeira = new Celula();
            ultima = primeira;
            qtde = 0;
        }
        public void RemoverApos(Object item)
        {
            Celula aux = primeira.Prox;
            bool achou = false;
            int count = 1;
            if(primeira != ultima)
            {
                while(aux != null && !achou)
                {
                    if(aux.Item.Equals(item))
                    {
                        achou = true;
                        ultima = aux;
                        ultima.Prox = null;
                        qtde = count;
                        
                    } else
                    {
                        aux = aux.Prox;
                        count++;
                    }
                }
            } else
            {
                Console.WriteLine("A lista está vazia.");
            }
        }
    }
}

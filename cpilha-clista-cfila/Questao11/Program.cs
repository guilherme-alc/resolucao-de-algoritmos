namespace Questao11
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
    internal class Lista
    {
        private Celula primeira;
        private Celula ultima;
        public int qtd = 0;
        public Lista()
        {
            primeira = new Celula();
            ultima = primeira;
        }
        public void RemovePos(int n)
        {
            if(primeira != ultima)
            {
                if (n >= 0 && n < qtd)
                {
                    Celula aux = primeira;
                    for(int posicao = 0; posicao < n; posicao++)
                    {
                        aux = aux.Prox;
                    }
                    Celula removida = aux.Prox;
                    aux.Prox = removida.Prox;

                    if (removida == ultima)
                    {
                        ultima = aux;
                    }
                    qtd--;
                } else
                {
                    Console.WriteLine("Posicão inválida");
                }
            } else
            {
                Console.WriteLine("A lista está vazia");
            }
        }
    }
}

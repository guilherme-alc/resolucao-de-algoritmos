namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class CCelula
    {
        public Object Item;
        public CCelula Prox;
        public CCelula()
        {
            Item = null;
            Prox = null;
        }
        public CCelula(Object valorItem)
        {
            Item = valorItem;
            Prox = null;
        }
        public CCelula(Object valorItem, CCelula valorProx)
        {
            Item = valorItem;
            Prox = valorProx;
        }
    }
    public class CLista
    {
        private CCelula primeira;
        private CCelula ultima;
        private int qtd = 0;
        public CLista()
        {
            primeira = new CCelula();
            ultima = primeira;
        }
        public void InsereDepoisDe(Object ElementoAInserir, Object Elemento)
        {
            CCelula aux = primeira;
            bool achou = false;
            if(primeira != ultima)
            {
                while (!achou && aux.Prox != null)
                {
                    if(aux.Item.Equals(Elemento))
                    {
                        if(aux.Prox == null)
                        {
                            ultima.Prox = new CCelula(ElementoAInserir);
                            ultima = ultima.Prox;
                            qtd++;
                        } else
                        {
                            aux.Prox = new CCelula(ElementoAInserir, aux.Prox.Prox);
                            qtd++;
                        }
                    } else
                    {
                        aux = aux.Prox;
                    }
                }
            }
        }
    }
}

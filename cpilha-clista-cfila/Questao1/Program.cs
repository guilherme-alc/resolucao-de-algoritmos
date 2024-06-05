using System.Resources;

namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    internal class CCelula
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
    internal class CLista
    {
        private CCelula primeira;
        private CCelula ultimo;
        private int qtd = 0;
        public CLista()
        {
            primeira = new CCelula();
            ultimo = primeira;
        }

        public void InsereAntesDe(Object ElementoAInserir, Object Elemento)
        {
            CCelula aux = primeira;
            bool achou = false;
            if(primeira != ultimo)
            {
                while(!achou && aux.Prox != null)
                {
                    if(aux.Prox.Item.Equals(Elemento))
                    {
                        achou = true;
                        aux.Prox = new CCelula(ElementoAInserir, aux.Prox);
                        qtd++;
                    } else
                    {
                        aux = aux.Prox;
                    }
                }
            }
        }
    }
}

namespace Questao10
{
    internal class Program
    {
        //Deque (Double-ended-queue) é um Tipo Abstrato de Dados (TAD) que funciona como uma Fila e como uma Pilha, permitindo que itens sejam adicionados em ambos os extremos. Implemente a classe Deque, usando duplo encadeamento
        static void Main(string[] args)
        {

        }
    }

    internal class CDeque
    {
        private CCelulaDup primeira;
        private CCelulaDup ultima;
        private int count = 0;
        public CDeque()
        {
            primeira = new CCelulaDup();
            ultima = primeira;
        }
        public bool IsEmpty ()
        {
            return primeira == ultima;
        }
        public int Size ()
        {
            return count;
        }
        public void pushLeft(Object item)
        {
            if(primeira == ultima)
            {
                ultima.Prox = new CCelulaDup(item, ultima, null);
                ultima = ultima.Prox;
            }
            else
            {
                primeira.Prox = new CCelulaDup(item, primeira, primeira.Prox);
                primeira.Prox.Prox.Ant = primeira.Prox;
            }
            count++;
        }
        public void pushRight(Object item)
        {
            ultima.Prox = new CCelulaDup(item, ultima, null);
            ultima = ultima.Prox;
        }
        public void popLeft()
        {
            if(primeira != ultima)
            {
                primeira = primeira.Prox;
                primeira.Ant = null;
                count--;
            }
        }
        public void popRight() 
        {
            if (primeira != ultima)
            {
                ultima = ultima.Ant;
                ultima.Prox = null;
                count--;
            }
        }
    }

    internal class CCelulaDup
    {
        public CCelulaDup Ant;
        public Object Item;
        public CCelulaDup Prox;
        public CCelulaDup()
        {
            Item = null;
            Ant = null;
            Prox = null;
        }
        public CCelulaDup(Object valorItem)
        {
            Item = valorItem;
            Ant = null;
            Prox = null;
        }
        public CCelulaDup(Object valorItem, CCelulaDup antCelula, CCelulaDup proxCelula)
        {
            Item = valorItem;
            Ant = antCelula;
            Prox = proxCelula;
        }
    }
}

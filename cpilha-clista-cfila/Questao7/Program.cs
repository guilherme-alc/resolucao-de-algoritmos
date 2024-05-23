namespace Questao7
{
    internal class Program
    {
        //A classe RandomQueue é uma Fila que retorna elementos aleatórios ao invés de sempre retornar o primeiro elemento.
        static void Main(string[] args)
        {
            RandomQueue RQ = new RandomQueue();
            RQ.Enqueue("Joao");
            RQ.Enqueue("Pedro");
            RQ.Enqueue("Camila");
            RQ.Enqueue("Roberto");
            RQ.Enqueue("Priscila");
            RQ.Enqueue("Fernanda");
            RQ.Enqueue("Alvarez");
            RQ.Enqueue("Humberto");
            RQ.Imprimir();
            Console.WriteLine(RQ.Dequeue());
            RQ.Imprimir();
        }
    }
    internal class RandomQueue
    {
        public CCelula Frente;
        public CCelula Tras;
        private int _qtd = 0;
        private Random _rnd = new Random();
        public RandomQueue()
        {
            Frente = new CCelula();
            Tras = Frente;
        }
        public bool IsEmpty()
        {
            return Frente == Tras;
        }
        public void Enqueue (Object valor)
        {
            Tras.Prox = new CCelula(valor);
            Tras = Tras.Prox;
            _qtd++;
        }
        public Object Dequeue()
        {
            if(Frente != Tras)
            {
                CCelula aux = Frente;
                bool achou = false;
                int indiceAleatorio = _rnd.Next(0, _qtd);
                int indice = 0;
                while (aux.Prox != null && !achou)
                {
                    achou = indice.Equals(indiceAleatorio);
                    if(!achou)
                    {
                        aux = aux.Prox;
                        indice++;
                    }
                }
                Object itemRemovido = aux.Prox.Item;

                aux.Prox = aux.Prox.Prox;
                if(aux.Prox == null)
                {
                    Tras = aux;
                }
                _qtd--;

                return itemRemovido;
            } else
            {
                return null;
            }
        }
        public Object Sample()
        {
            if(Frente != Tras)
            {
                bool achou = false;
                int indiceAleatorio = _rnd.Next(0, _qtd);
                int indice = 0;
                CCelula aux = Frente;
                for (; aux.Prox != null && !achou; aux = aux.Prox)
                {
                    achou = indice.Equals(indiceAleatorio);
                    indice++;
                }
                return aux.Item;

            } else
            {
                return null;
            }
        }
        public void Imprimir ()
        {
            Console.Write("[ ");
            for(CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
            {
                Console.Write(aux.Item + " ");
            }
            Console.Write("]");
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
}

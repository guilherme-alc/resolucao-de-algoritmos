using System.Diagnostics;

namespace Questao32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CListaSimples lista = new CListaSimples();
            lista.insereFim(1);
            lista.insereFim(2);
            lista.insereFim(3);
            lista.imprime(); // Saída esperada: [ 1 2 3 ]
            Console.WriteLine(lista.contem(2)); // Saída esperada: True
            Console.WriteLine(lista.contem(4)); // Saída esperada: False
            Console.WriteLine(lista.removeFim()); // Saída esperada: 3
            lista.imprime(); // Saída esperada: [ 1 2 ]
        }
    }
    class CCelula
    {
        public int item;
        public CCelula prox;
        public CCelula()
        {
        }
        public CCelula(int valorItem)
        {
            item = valorItem;
        }
        public CCelula(int valorItem, CCelula valorProx)
        {
            item = valorItem;
            prox = valorProx;
        }
    }
    class CListaSimples
    {
        private CCelula primeira, ultima;

        public CListaSimples()
        {
            primeira = null;
            ultima = null;
        }

        public bool vazia()
        {
            return primeira == null;
        }

        public void insereComeco(Object valorItem)
        {
            CCelula nova = new CCelula((int)valorItem, primeira);
            primeira = nova;
            if (ultima == null)
            {
                ultima = nova;
            }
        }

        public Object removeComeco()
        {
            Object item = null;
            if (primeira != null)
            {
                item = primeira.item;
                primeira = primeira.prox;
                if (primeira == null)
                {
                    ultima = null;
                }
            }
            return item;
        }

        public void insereFim(Object valorItem)
        {
            CCelula nova = new CCelula((int)valorItem);
            if (ultima != null)
            {
                ultima.prox = nova;
            }
            ultima = nova;
            if (primeira == null)
            {
                primeira = nova;
            }
        }

        public Object removeFim()
        {
            Object item = null;
            if (primeira != null)
            {
                if (primeira == ultima)
                {
                    item = primeira.item;
                    primeira = ultima = null;
                }
                else
                {
                    CCelula aux = primeira;
                    while (aux.prox != ultima)
                    {
                        aux = aux.prox;
                    }
                    item = ultima.item;
                    ultima = aux;
                    ultima.prox = null;
                }
            }
            return item;
        }

        public void imprime()
        {
            CCelula aux = primeira;
            Console.Write("[ ");
            while (aux != null)
            {
                Console.Write(aux.item + " ");
                aux = aux.prox;
            }
            Console.WriteLine("]");
        }

        public bool contem(Object elemento)
        {
            CCelula aux = primeira;
            while (aux != null)
            {
                if (aux.item.Equals(elemento))
                {
                    return true;
                }
                aux = aux.prox;
            }
            return false;
        }
    }
}

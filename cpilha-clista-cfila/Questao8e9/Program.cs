namespace Questao8
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
        public Celula Ant;
        public Celula Prox;
        public Celula()
        {
            Item = null;
            Ant = null;
            Prox = null;
        }
        public Celula(Object valorItem)
        {
            Item = valorItem;
            Ant = null;
            Prox = null;
        }
        public Celula(Object valorItem, Celula valorAnt, Celula valorProx)
        {
            Item = valorItem;
            Ant = valorAnt;
            Prox = valorProx;
        }
    }
    internal class CListaDup
    {
        private Celula primeira;
        private Celula ultima;
        private int qtd;
        public int primeiraOcorrenciaDe(Object elemento)
        {
            Celula aux = primeira.Prox;
            int indiceElem = 0;
            int posicao = 1;
            bool achou = false;
            if(primeira != ultima)
            {
                while(aux != null && !achou)
                {
                    if(aux.Item.Equals(elemento)) 
                    {
                        indiceElem = posicao;
                        achou = true;
                    }
                    posicao++;
                    aux = aux.Prox;
                }
            }
            return indiceElem;
        }
        public int ultimaOcorrenciaDe(Object elemento)
        {
            Celula aux = primeira.Prox;
            int ultimoIndice = 0;
            int posicao = 1;
            if (primeira != ultima ) 
            {
                while(aux != null)
                {
                    if(aux.Item.Equals(elemento))
                    {
                        ultimoIndice = posicao;
                    }
                    posicao++;
                    aux = aux.Prox;
                }
            }
            return ultimoIndice;
        }
    }
}

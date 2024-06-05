namespace Questao16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16 - Crie na CLista o método Object[] copiaParaVetor() que copia todos os elementos da Lista para um vetor.
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
    internal class Fila
    {
        private Celula primeira;
        private Celula ultima;
        private int qtd;
        public Fila()
        {
            primeira = new Celula();
            ultima = primeira;
        }
        public Object[] copiaParaVetor()
        {
            Object[] copia = new Object[qtd];
            if(primeira != ultima)
            {
                Celula aux = primeira.Prox;
                int indice = 0;
                while(aux != null)
                {
                    copia[indice] = aux.Item;
                    indice++;
                    aux = aux.Prox;
                }
            }
            return copia;
        }
    }
}

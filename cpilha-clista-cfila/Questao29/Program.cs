namespace Questao29
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
    internal class CFila
    {
        private Celula frente;
        private Celula tras;
        private int qtd;
        public CFila()
        {
            frente = new Celula();
            tras = frente;
            qtd = 0;
        }
        public void FuraFila(Object elemento)
        {
            Celula novaCelula = new Celula(elemento, frente.Prox);
            frente.Prox = novaCelula;
            if (frente == tras)
            {
                tras = novaCelula;
            }
            qtd++;
        }
    }
}

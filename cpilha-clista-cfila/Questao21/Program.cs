namespace Questao21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21 – Crie a função construtora CFila(Object[] vetor) na classe CFila que receba um vetor de Object como parâmetro e crie a fila com todos os elementos do vetor.
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
        private Celula frente;
        private Celula tras;
        private int qtd;
        public Fila()
        {
            frente = new Celula();
            tras = frente;
            qtd = 0;
        }
        public Fila(Object[] vetor)
        {
            frente = new Celula();
            tras = frente;
            qtd = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                tras.Prox = new Celula(vetor[i]);
                tras = tras.Prox;
                qtd++;
            }
        }
    }
}

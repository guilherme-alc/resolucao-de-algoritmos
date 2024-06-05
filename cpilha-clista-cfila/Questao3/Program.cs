namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        public void InsereOrdenado(int ElementoAInserir)
        {
            CCelula novaCelula = new CCelula(ElementoAInserir);
            if (primeira.Prox == null)
            {
                primeira.Prox = novaCelula;
                ultima = novaCelula;
            }
            else
            {
                CCelula anterior = primeira;
                CCelula atual = primeira.Prox;
                while (atual != null && (int)atual.Item < ElementoAInserir)
                {
                    anterior = atual;
                    atual = atual.Prox;
                }
                novaCelula.Prox = atual;
                anterior.Prox = novaCelula;
                if (atual == null)
                {
                    ultima = novaCelula;
                }
            }
            qtd++;
        }
    }
}

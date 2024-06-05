using System.Xml.Linq;

namespace Questao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 – Crie na CFila o método int qtdeOcorrencias(Object elemento) a qual retorna a quantidade de vezes o elemento passado como parâmetro está armazenado na CFila.
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
        }
        public int qtdeOcorrencias(Object elemento)
        {
            int quantidade = 0;
            Celula aux = frente.Prox;
            while (aux != null)
            {
                if(aux.Item.Equals(elemento))
                {
                    quantidade++;
                }
                aux = aux.Prox;
            }                
            return quantidade;
        }
    }
}

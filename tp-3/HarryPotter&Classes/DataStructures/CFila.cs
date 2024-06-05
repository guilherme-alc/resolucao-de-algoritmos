using HarryPotter_Classes.Models;

namespace HarryPotter_Classes.DataStructures
{
    internal class CFila
    {
        private CCelula primeiro;
        private CCelula ultimo;
        private int count = 0;
        public CFila()
        {
            primeiro = new CCelula();
            ultimo = primeiro;
        }
        public void Enfi (Personagem personagem)
        {
            ultimo.Prox = new CCelula(personagem);
            ultimo = ultimo.Prox;
            count++;
        }
        public Personagem Desenfi()
        {
            Personagem pRemovido = null;
            if(ultimo != primeiro)
            {
                primeiro = primeiro.Prox;
                pRemovido = primeiro.Item;
                count--;
            }
            return pRemovido;
        }
        public bool TemCFil(string nomePersonagem)
        {
            bool achou = false;
            CCelula aux = primeiro;
            while(aux != null && !achou)
            {
                achou = aux.Item.GetNome(nomePersonagem);
                aux = aux.Prox;
            }
            return achou;
        }
        public Personagem Peek()
        {
            if (ultimo != primeiro)
                return primeiro.Prox.Item;
            return null;
        }
        public int Count()
        {
            return count;
        }
        public bool EstaVazia()
        {
            return ultimo == primeiro;
        }
        public void Imprimir()
        {
            Console.Write("[ ");
            for (CCelula aux = primeiro.Prox; aux != null; aux = aux.Prox)
                Console.Write(aux.Item + " ");
            Console.Write("]");
        }
    }
}

using HarryPotter_Classes.Models;

namespace HarryPotter_Classes.DataStructures
{
    internal class CPilha
    {
        private CCelula topo = null;
        private int count = 0;
        public CPilha()
        {
            
        }
        public void Empi (Personagem personagem)
        {
            topo = new CCelula(personagem, topo);
            count++;
        }
        public Personagem Desempi ()
        {
            Personagem pRemovido = null;
            if (topo != null)
            {
                pRemovido = topo.Item;
                topo = topo.Prox;
                count--;
                
            }
            return pRemovido;
        }
        public bool TemCPil(string nomePersonagem)
        {
            bool achou = false;
            CCelula aux = topo;
            while(!achou && aux != null)
            {
                achou = aux.Item.GetNome(nomePersonagem);
                aux = aux.Prox;
            }
            return achou;
        }
        public Personagem Peek()
        {
            if (topo != null)
                return topo.Item;
            else
                return null;
        }
        public int Count()
        {
            return count;
        }
    }
}

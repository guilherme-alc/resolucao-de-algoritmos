using HarryPotter_Classes.Models;
namespace HarryPotter_Classes.DataStructures
{
    internal class CLista
    {
        private CCelula frente;
        private CCelula tras;
        private int count = 0;
        public CLista()
        {
            frente = new CCelula();
            tras = frente;
        }
        public void InsFim(Personagem personagem)
        {
            tras.Prox = new CCelula(personagem);
            tras = tras.Prox;
            count++;
        }
        public void InsIni(Personagem personagem)
        {
            frente.Prox = new CCelula(personagem, frente.Prox);
            if(frente.Prox.Prox == null)
            {
                tras = frente.Prox;
            }
            count++;
        }
        public Personagem RemFim()
        {
            Personagem pRemovido = null;
            if(frente != tras)
            {
                CCelula aux = frente;
                while(aux.Prox != tras)
                {
                    aux = aux.Prox;
                }
                pRemovido = tras.Item;
                tras = aux;
                tras.Prox = null;
                count--;
                if (frente == tras)
                {
                    tras = frente;
                }
            }
            return pRemovido;
        }
        public Personagem RemIni() 
        {
            Personagem pRemovido = null;
            if(frente != tras)
            {
                pRemovido = frente.Prox.Item;
                frente.Prox = frente.Prox.Prox;
                count--;
                if (frente.Prox == null)
                {
                    tras = frente;
                }

            }
            return pRemovido;
        }
        public int Count()
        {
            return count;
        }
    }
}

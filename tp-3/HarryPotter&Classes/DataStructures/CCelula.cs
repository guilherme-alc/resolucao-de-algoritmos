using HarryPotter_Classes.Models;

namespace HarryPotter_Classes.DataStructures
{
    internal class CCelula
    {
        public Personagem Item;
        public CCelula Prox;
        public CCelula()
        {
            Item = null;
            Prox = null;
        }
        public CCelula(Personagem valorItem)
        {
            Item = valorItem;
            Prox = null;
        }
        public CCelula(Personagem valorItem, CCelula valorProx)
        {
            Item = valorItem;
            Prox = valorProx;
        }
    }
}

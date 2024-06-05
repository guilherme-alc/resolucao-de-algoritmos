namespace Questao17
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class CelulaDup
    {
        public Object Item;
        public CelulaDup Ant;
        public CelulaDup Prox;
        public CelulaDup()
        {
            Item = null;
            Ant = null;
            Prox = null;
        }
        public CelulaDup(Object valorItem)
        {
            Item = valorItem;
            Prox = null;
            Ant = null;
        }
        public CelulaDup(Object valorItem, CelulaDup valorAnt, CelulaDup valorProx)
        {
            Item = valorItem;
            Ant = valorAnt;
            Prox = valorProx;
        }
    }
    internal class CListaDup
    {
        private CelulaDup primeira;
        private CelulaDup ultima;
        private int qtde;
        public CListaDup(Object[] VET)
        {
            primeira = new CelulaDup();
            ultima = primeira;
            qtde = 0;
            for(int i = 0; i < VET.Length; i++)
            {
                if(primeira == ultima)
                {
                    ultima.Prox = new CelulaDup(VET[i]);
                    ultima = ultima.Prox;
                    qtde++;
                } else
                {
                    ultima.Prox = new CelulaDup(VET[i], ultima, null);
                    ultima = ultima.Prox;
                    qtde++;
                }
            }
        }
    }
}

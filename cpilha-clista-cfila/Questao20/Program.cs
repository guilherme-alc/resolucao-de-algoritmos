namespace Questao20
{
    internal class Program
    {
        //20 – Cria o método void Limpar() para todas as classes (CLista, CListaDup, CFila e CPilha), o qual deve remover todos os itens da estrutura.

        //CLista e CListaDup:
        public void Limpar()
        {
            primeira = new Celula();
            ultima = primeira;
            qtd = 0;
        }

        //CFila
        public void Limpar()
        {
            frente = new Celula();
            tras = frente;
            qtd = 0;
        }

        //CPilha
        public void Limpar()
        {
            topo = null;
            qtd = 0;
        }
    }
}

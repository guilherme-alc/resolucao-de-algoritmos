using System.Collections;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2), o qual retorna um novo ArrayList como todos os elementos de AL1 e AL2.
            ArrayList al1 = new ArrayList() {1, 10, 100, 1000, 12};
            ArrayList al2 = new ArrayList() {2, 20, 200, 2000, 21};
            ArrayList AmaisB = ConcatenaArrayList(al1 , al2);
        }
        public static ArrayList ConcatenaArrayList(ArrayList al1, ArrayList al2)
        {
            int tamanho = al1.Count + al2.Count;
            ArrayList temp = new ArrayList(tamanho);
            for(int i = 0, j = 0; i < tamanho; i++)
            {
                if(i < al1.Count)
                {
                    temp.Add(al1[i]);
                } else
                {
                    temp.Add(al2[j]);
                    j++;
                }
            }
            return temp;
        }
    }
}

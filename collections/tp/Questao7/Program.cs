using System.Collections;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie o procedimento public void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3), o qual copia todos os elementos de AL1 e AL2 para AL3.
            Random rnd = new Random();
            ArrayList al1 = new ArrayList(6);
            ArrayList al2 = new ArrayList(6);
            for(int i = 0; i < 6; i++)
            {
                int inteiro = rnd.Next(1, 100);
                al1.Add(inteiro);
                int inteiro2 = rnd.Next(100, 200);
                al2.Add(inteiro2);
            }
            ArrayList al3 = new ArrayList(al1.Count + al2.Count);
            ConcatenaArrayList2(al1 , al2, al3);
        }
        public static void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3)
        {
            int tamanho = AL1.Count + AL2.Count;
            for(int i = 0, j = 0; i < tamanho; i++)
            {
                if(AL1.Count > i)
                {
                    AL3.Add(AL1[i]);
                } else
                {
                    AL3.Add(AL2[j]);
                    j++;
                }
            }
        }
    }
}

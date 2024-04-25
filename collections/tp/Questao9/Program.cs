using System.Collections;

namespace Questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie o procedimento public void ApagaRepetidos(ArrayList AL) que apaga todos os elementos repetidos do ArrayList AL recebido como parâmetro, mantendo apenas a 1ª ocorrência de cada elemento.
            ArrayList al = new ArrayList() { 1, 1, 1, 2, 2, 3, 4, 5, 6, 6, 7, 7, 7, 7, 1, 2, 1, 2, 4, 3, 3, 1, 2 };
            ApagaRepetidos(al);
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
        }
        public static void ApagaRepetidos(ArrayList AL)
        {
            ArrayList temp = new ArrayList();
            foreach(int elem in AL)
            {
                if(!temp.Contains(elem))
                {
                    temp.Add(elem);
                }
            }
            AL.Clear();
            AL.AddRange(temp);
        }
    }
}

using System.Collections;

namespace Questao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public int QtdeOcorrencias(ArrayList AL, Object elemento) a qual retorna a quantidade de vezes que o elemento passado como parâmetro está armazenado no ArrayList.
            ArrayList al = new ArrayList() { 1, 1, 2, 3, 4, 5, 1, 4, 2, 1, 4, 2, 5, 6, 7, 7, 3, 5, 6, 7, 4, 2, 4, 3, 2 };
            int qtde = QtdeOcorrencias(al, 5);
            Console.WriteLine(qtde);
        }
        public static int QtdeOcorrencias(ArrayList al, int n)
        {
            int qtd = 0;
            foreach (int i in al)
            {
                if(i == n) 
                    qtd++;
            }
            return qtd;
        }
    }
}

using System.Collections;

namespace Questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public ArrayList OcorrenciasDe(ArrayList AL, Object elemento) o qual retorna um vetor contendo todas as posições que contem o elemento passado como parâmetro.
            ArrayList al = new ArrayList() {1, 1, 2, 3, 4, 5, 1, 4, 2, 1, 4, 2, 5, 6, 7, 7, 3, 5, 6, 7, 4, 2, 4, 3, 2};
            int[] vet = OcorrenciasDe(al, 3);
        }
        public static int[] OcorrenciasDe(ArrayList AL, int elemento) 
        {
            int tamanho = 0;
            for(int i = 0; i < AL.Count; i++)
            {
                if ((int) AL[i] == elemento)
                {
                    tamanho++;
                }
            }
            int[] vet = new int[tamanho];
            int aux = 0;
            for(int j = 0; j < AL.Count; j++)
            {
                if((int)AL[j] == elemento)
                {
                    vet[aux] = j;
                    aux++;
                }
            }
            return vet;
        }
    }
}

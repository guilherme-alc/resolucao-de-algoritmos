namespace ImprimePosicaoImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 5, 6, 10, 21, 32, 43, 11 };
            int posicao = 0;
            ImprimeImpares(vetor, posicao);
        }

        static void ImprimeImpares(int[] vetor, int posicao)
        {
            if (posicao < vetor.Length)
            {
            int elemento = vetor[posicao];
                if(posicao % 2 != 0)
                {
                    ImprimeImpares(vetor, posicao + 1);
                }
                else
                {
                    Console.WriteLine(elemento);
                    ImprimeImpares(vetor, posicao + 1);
                }
            }
        }
    }
}

namespace ProcuraOcorrenciasVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 4, 5, 7, 8, 5, 4, 2, 10, 4, 5, 15, 10, 10, 10, 5, 10, 4 };
            int elemento = int.Parse(Console.ReadLine());
            int posicao = 0;
            int count = 0;
            int ocorrencias = ProcuraOcorrencias(vetor, elemento, posicao, count);
            Console.WriteLine(ocorrencias);
        }

        static int ProcuraOcorrencias(int[] vetor, int elemento, int posicao, int count)
        {
            if(posicao < vetor.Length)
            {
                if (vetor[posicao] == elemento)
                {
                    count++;
                    return ProcuraOcorrencias(vetor, elemento, posicao + 1, count);
                } else
                {
                    return ProcuraOcorrencias(vetor, elemento, posicao +1, count);
                }
            }
            return count;
        }
    }
}

namespace SomaParesVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 8, 11, 13, 15, 16, 20, 24 };
            int posicao = 0;
            int soma = 0;
            int resultado = SomaPares(vetor, posicao, soma);
            Console.WriteLine(resultado);
        }
        static int SomaPares(int[] vetor, int posicao, int soma)
        {
            if(posicao < vetor.Length)
            {
                if (vetor[posicao] % 2 == 0)
                {
                    soma = vetor[posicao] + SomaPares(vetor, posicao + 1, soma);
                } else
                {
                    return SomaPares(vetor, posicao + 1, soma);
                }
            }
            return soma;
        }
    }
}

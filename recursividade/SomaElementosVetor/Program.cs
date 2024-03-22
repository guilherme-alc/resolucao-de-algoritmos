namespace SomaElementosVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int [] { 1, 2, 3, 4, 5, 8, 10, 11, 17, 20 };
            int posicao = 0;
            int soma = 0;
            int resultado = SomaVetor(vetor, posicao, soma);
            Console.WriteLine(resultado);
        }
        static int SomaVetor(int[ ] vetor, int posicao, int soma)
        {
            if(posicao < vetor.Length)
            {
                soma = vetor[posicao] + SomaVetor(vetor, posicao + 1, soma);

            }
            return soma;
        }
    }
}

namespace ProcuraElementoVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[] { 1, 2, 3, 4, 5, 6, 4, 8, 4, 9, 10, 15, 4 };
            int posicao = 0;
            bool encontrado = false;
            int elemento = int.Parse(Console.ReadLine());
            bool resultado = ProcuraElemento(vetor, posicao, encontrado, elemento);
            if(resultado)
            {
                Console.WriteLine($"Elemento encontrado no vetor");
            } else
            {
                Console.WriteLine("Elemento não encontrado no vetor");
            }
        }

        static bool ProcuraElemento(int[] vetor, int posicao, bool encontrado, int elemento) 
        {
            if(posicao < vetor.Length)
            {
                if (vetor[posicao] == elemento)
                {
                    encontrado = true;
                } else
                {
                    return ProcuraElemento(vetor, posicao + 1, encontrado, elemento);
                }
            }
            return encontrado;
        }
    }
}

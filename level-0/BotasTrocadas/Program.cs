namespace BotasTrocadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int botaDireita = 0;
            int botaEsquerda = 0;
            int parDeBotas = 0;
            int numBotas = int.Parse(Console.ReadLine());
            string[,] listaBotas = new string[numBotas, 2];
            for (int i = 0; i < numBotas; i++) 
            {
                string [] bota = Console.ReadLine().Split(" ");
                for(int j = 0; j < 2; j++)
                {
                    listaBotas[i, j] = bota[j];
                }
            }
            for (int j = 0; j < numBotas; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    Console.Write($"{listaBotas[j, k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

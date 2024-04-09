namespace BotasTrocadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] botasEsquerda = new int[61], botasDireita = new int[61];

            int qtdBotas = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdBotas; i++) 
            {
                string [] bota = Console.ReadLine().Split(" ");
                int tamanhoDaBota = int.Parse(bota[0]);
                string ladoDaBota = bota[1];

                if(ladoDaBota == "E")
                {
                    botasEsquerda[tamanhoDaBota] += 1;
                } else
                {
                    botasDireita[tamanhoDaBota] += 1;
                }
            }

            int paresFormados = 0;

            for(int i = 0; i < 61; i++)
            {
                paresFormados += botasEsquerda[i] > botasDireita[i] ? botasDireita[i] : botasEsquerda[i];
            }
            Console.WriteLine(paresFormados);
        }
    }
}

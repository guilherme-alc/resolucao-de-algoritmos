using System;
internal class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string[] valoresEntrada = entrada.Split(' ');

        int linhas = int.Parse(valoresEntrada[0]);
        int colunas = int.Parse(valoresEntrada[1]);
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            string[] linha = Console.ReadLine()
                                     .Trim()
                                     .Split(' ');
            int[] valoresInteiros = new int[linha.Length];
            for (int j = 0; j < valoresInteiros.Length; j++)
            {
                valoresInteiros[j] = int.Parse(linha[j]);
                matriz[i, j] = valoresInteiros[j];
            }
        }
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] != matriz[j, i])
                {
                    Console.WriteLine(0);
                    return;
                } 
                else
                {
                    count++;
                }
            }
        }
        if (count == linhas * colunas)
        {
            Console.WriteLine(1);
        }
    }
}

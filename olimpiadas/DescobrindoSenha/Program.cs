using System;

namespace DescobrindoSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            bool continua = true;
            while (continua)
            {
                string entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                {
                    continua = false;
                    continue;
                }
                int N = int.Parse(entrada);
                if (N > 0 && N < 11)
                {
                    string[] V = Console.ReadLine().Split(' ');
                    int[] vetSenha = new int[V.Length];
                    double[] vetMancha = new double[V.Length];
                    for (int i = 0; i < V.Length; i++)
                    {
                        vetMancha[i] = double.Parse(V[i]);
                        vetSenha[i] = i;
                    }
                    for (int i = 0; i < V.Length - 1; i++)
                    {
                        for (int j = 0; j < V.Length - 1 - i; j++)
                        {
                            if (vetMancha[vetSenha[j]] < vetMancha[vetSenha[j + 1]] ||
                                (vetMancha[vetSenha[j]] == vetMancha[vetSenha[j + 1]] && vetSenha[j] > vetSenha[j + 1]))
                            {
                                int temp = vetSenha[j];
                                vetSenha[j] = vetSenha[j + 1];
                                vetSenha[j + 1] = temp;
                            }
                        }
                    }
                    Console.Write($"Caso {count}: ");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write(vetSenha[i]);
                    }
                    Console.WriteLine();
                    count++;
                }
                else
                {
                    continua = false;
                }
            }
        }
    }
}

using System;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdExperimento = int.Parse(Console.ReadLine());
        for(int i = 0; i < qtdExperimento; i++)
        {
            int distancia = int.Parse(Console.ReadLine());
            for(int j = 0; j < distancia; j = j + 8)
            {
                if(distancia > 5 && j == 0)
                {
                    if (distancia == 5 + 1)
                    {
                        Console.WriteLine(1);
                    } else if (distancia == 5 + 2)
                    {
                        Console.WriteLine(2);
                    } else if ( distancia == 5 + 3)
                    {
                        Console.WriteLine(3);
                    }
                } else
                {
                    if (distancia == 6 + j)
                    {
                        Console.WriteLine(1);
                    }
                    else if (distancia == 7 + j)
                    {
                        Console.WriteLine(2);
                    }
                    else if (distancia == 8 + j)
                    {
                        Console.WriteLine(3);
                    }
                }
            }

        }
    }
}


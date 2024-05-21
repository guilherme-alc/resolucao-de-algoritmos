using System;

class Program
{
    static void Main(string[] args)
    {
        long [] soma = new long[21];
        soma[0] = 1;

        int linha = int.Parse(Console.ReadLine());
        if(linha >= 0 && linha <= 20)
        {
            if (linha == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 1; i <= linha; i++)
                {
                    soma[i] = soma[i - 1] * 3;
                }
                Console.WriteLine(soma[linha]);
            }
        }
    }
}

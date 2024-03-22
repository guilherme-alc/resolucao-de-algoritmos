using System;
internal class Program
{
    static void Main(string[] args)
    {
        int megabytes = int.Parse(Console.ReadLine());
        int meses = int.Parse(Console.ReadLine());
        int diferenca = 0;
        int acumulo = 0;
        for(int i = 0; i < meses; i++)
        {
            acumulo += megabytes;
            int mgUsado = int.Parse(Console.ReadLine());
            diferenca = acumulo - mgUsado;
            acumulo = diferenca;

        }
        int saldoUltimoMes = acumulo + megabytes;
        Console.WriteLine(saldoUltimoMes);
    }
}
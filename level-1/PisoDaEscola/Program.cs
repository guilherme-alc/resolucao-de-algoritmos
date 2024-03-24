using System;
internal class Program
{
    static void Main(string[] args)
    {
        int largura = int.Parse(Console.ReadLine());
        int comprimento = int.Parse(Console.ReadLine());

        double lajota;
        double metadeLajota;
        metadeLajota = (2 * (comprimento - 1)) + (2 * (largura - 1));
        lajota = (largura * comprimento) + ((largura - 1) * (comprimento - 1));

        Console.WriteLine(lajota);
        Console.WriteLine(metadeLajota);
    }
}

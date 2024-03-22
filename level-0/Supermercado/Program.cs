using System;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdMercado = int.Parse(Console.ReadLine());
        double menor = double.MaxValue;
        for(int i = 0; i < qtdMercado; i++) 
        {
            int x = 1;
            string linhaEntrada = Console.ReadLine();
            string[] partes = linhaEntrada.Split(" ");
            double preco = double.Parse(partes[0]);
            int grama = int.Parse(partes[1]);
            double resultado = (preco * 1000) / (grama * x);
            if(resultado < menor) 
            {
                menor = resultado;
            }

        }
        Console.WriteLine("{0:F2}", menor);
    }
}


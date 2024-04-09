using System;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdDeLinhas = int.Parse(Console.ReadLine());
        Repeticao(qtdDeLinhas);
    }

    static void Repeticao(int qtdDeLinhas)
    {
        if(qtdDeLinhas > 0)
        {
            string [] sequenciaDeNumeros = Console.ReadLine().Split(" ");
            int tamanho = sequenciaDeNumeros.Length;

            InverteOrdem(sequenciaDeNumeros, tamanho);
            Console.WriteLine();

            Repeticao(qtdDeLinhas - 1);
        }
    }

    static void InverteOrdem(string [] sequencia, int tamanho)
    {
        if(tamanho != 0)
        {
            Console.Write(sequencia[tamanho -1] + " ");
            InverteOrdem(sequencia, tamanho - 1);
        }
    }
}


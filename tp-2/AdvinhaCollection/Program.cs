using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdCasoTeste = 1;
        while (qtdCasoTeste != 0)
        {
            qtdCasoTeste = Convert.ToInt16(Console.ReadLine());
            List<int> numerosEntrada = new List<int>();
            List<int> numerosSaida = new List<int>();
            for (int i = 0; i < qtdCasoTeste; i++)
            {
                string[] instrucao = Console.ReadLine().Split(" ");
                string comando = instrucao[0];
                int numero = Convert.ToInt16(instrucao[1]);
                if (comando == "I")
                {                        
                    numerosEntrada.Add(numero);
                } else if (comando == "R") 
                {
                    numerosSaida.Add(numero);
                }
            }
            if(qtdCasoTeste != 0)
            {
                string estrutua = "";
                if (numerosEntrada[0] == numerosSaida[0])
                {
                    estrutua = "queue";
                } else if (numerosEntrada[0] == numerosSaida[numerosSaida.Count -1] && numerosSaida[0] == numerosEntrada[numerosEntrada.Count -1])
                {
                    estrutua = "stack";
                } else
                {
                    estrutua = "list";
                }
                Console.WriteLine(estrutua);
            }
        }
    }
}
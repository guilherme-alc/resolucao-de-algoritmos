using System;
using System.Collections.Generic;
using System.Linq;
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
                int fila = 0;
                int stack = 0;
                int lista = 0;
                for(int i = 0, x = numerosEntrada.Count - 1 ;i < numerosEntrada.Count ;i++) 
                {
                    if (numerosEntrada[i] == numerosSaida[i])
                    {
                        fila++;
                    } else if (numerosEntrada[i] == numerosSaida[x] && numerosSaida[0] == numerosEntrada[numerosEntrada.Count - 1])
                    {
                        stack++;
                        x--;
                    } else
                    {
                        lista++;
                    }
                }

                if(fila == numerosEntrada.Count)
                {
                    Console.WriteLine("queue");
                } else if (stack == numerosEntrada.Count)
                {
                    Console.WriteLine("stack");
                } else if (lista == numerosEntrada.Count)
                {
                    Console.WriteLine("list");
                }
            }
        }
    }
}
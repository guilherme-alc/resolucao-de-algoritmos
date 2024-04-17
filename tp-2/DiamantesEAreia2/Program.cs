using System.Collections;
using System;
namespace DiamantesEAreia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes = int.Parse(Console.ReadLine());
            while(qtdTestes > 0)
            {
                string entrada = Console.ReadLine().Replace(".", "");
                Stack partesDiamantes = new Stack();
                int diamantesFormados = 0;
                for(int i = 0; i < entrada.Length; i++)
                {
                    if (entrada[i] == '<')
                    {
                        partesDiamantes.Push(entrada[i]);
                    } else if (entrada[i] == '>' && partesDiamantes.Contains('<'))
                    {
                        diamantesFormados++;
                        partesDiamantes.Pop();
                    }
                }
                Console.WriteLine(diamantesFormados);
                qtdTestes--;
            }
        }
    }
}

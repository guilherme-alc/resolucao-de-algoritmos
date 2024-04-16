using System;
using System.Collections;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdCasosTeste = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < qtdCasosTeste; i++)
        {
            string escavacao = Console.ReadLine();
            ArrayList ladoDireito = new ArrayList();
            ArrayList ladoEsquerdo = new ArrayList();
            int qtdDiamantes = 0;
            for(int j = 0; j < escavacao.Length; j++)
            {
                if (escavacao[j] == '<')
                {
                    ladoDireito.Add(escavacao[j]);
                } else if (escavacao[j] == '>')
                {
                    ladoEsquerdo.Add(escavacao[j]);
                }
            }
            if(ladoEsquerdo.Count >= ladoDireito.Count)
            {
                qtdDiamantes = ladoDireito.Count;
            } else
            {
                qtdDiamantes = ladoEsquerdo.Count;
            }
            Console.WriteLine(qtdDiamantes);
        }
    }
}


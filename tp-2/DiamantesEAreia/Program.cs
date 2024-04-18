using System;
internal class Program
{
    static void Main(string[] args)
    {
        int qtdCasosTeste = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < qtdCasosTeste; i++)
        {
            string escavacao = Console.ReadLine().Replace(".", "");
            int ladoEsquerdo = 0;
            int qtdDiamantes = 0;
            for(int j = 0; j < escavacao.Length; j++)
            {
                if (escavacao[j] == '<')
                {
                    ladoEsquerdo++;
                } else if (escavacao[j] == '>')
                {
                    if(ladoEsquerdo > 0)
                    {
                        qtdDiamantes++;
                        ladoEsquerdo--;
                    }
                }
            }
            Console.WriteLine(qtdDiamantes);
        }
    }
}


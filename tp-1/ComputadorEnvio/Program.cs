using System;
class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int numPosicoes = int.Parse(entrada[0]);
        int numInstrucoes = int.Parse(entrada[1]);
        int[] memoria = new int[numPosicoes];
        for (int i = 0; i < numInstrucoes; i++)
        {
            string[] descricao = Console.ReadLine().Split(' ');
            int instrucao = int.Parse(descricao[0]);
            int posicao = int.Parse(descricao[1]) - 1;
            int valor = 0;
            if (descricao.Length > 2)
            {
                valor = int.Parse(descricao[2]);
            }
            if (instrucao == 1)
            {
                memoria[posicao] += valor;
                while (valor > 0 && posicao <= numPosicoes)
                {
                    memoria[posicao++] += valor--;
                }
            }
            else if (instrucao == 2)
            {
                memoria[posicao] += valor;
                while (valor > 0 && posicao >= 1)
                {
                    memoria[posicao--] += valor--;
                }
            }
            else if (instrucao == 3)
            {
                Console.WriteLine(memoria[posicao]);
            }
        }
    }
}
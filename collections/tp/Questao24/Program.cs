using System.Collections.Generic;
namespace Questao24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public int QtdeOcorrencias(List<String> origem, String elemento), a qual retorna a quantidade de vezes que o elemento passado como parâmetro está armazenado no List<String> origem.
            List <string> list = new List<string>() {"21", "14", "21", "20", "22", "14", "12", "47", "78","21", "99", "55", "77", "21", "14"};
            int qtd = QtdeOcorrencias(list, "21");
            Console.WriteLine(qtd);
        }
        public static int QtdeOcorrencias(List<string> list, string elemento)
        {
            int qtd = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == elemento)
                {
                    qtd++;
                }
            }
            return qtd;
        }
    }
}

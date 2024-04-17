using System.Collections.Generic;
namespace Questao33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //33 – Faça um programa que monte a estrutura abaixo usando Dictionary<> ou SortedList<>:
            Dictionary<string, double> brasil = new Dictionary<string, double>() { ["Brasil"] = 202656784 };
            Dictionary<string, double> mexico = new Dictionary<string, double>() { ["México"] = 120286656 };
            Dictionary<string, double> eua = new Dictionary<string, double>() { ["Estados Unidos"] = 318892096 };
            Dictionary<string, double> guatemala = new Dictionary<string, double>() { {"Guatemala", 17153288 } };
            Dictionary<string, double> equador = new Dictionary<string, double>() { {"Equador", 16904868 } };
            Dictionary<string, double> colombia = new Dictionary<string, double>() { {"Colombia", 49084840 } };

            List<Dictionary<string, double>> paisesAmericanos = new List<Dictionary<string, double>>();
            paisesAmericanos.Add(brasil);
            paisesAmericanos.Add(mexico);
            paisesAmericanos.Add(eua);
            paisesAmericanos.Add(guatemala);
            paisesAmericanos.Add(equador);
            paisesAmericanos.Add(colombia);

            Dictionary<string, List<Dictionary<string, double>>> continentes = new Dictionary<string, List<Dictionary<string, double>>>();
            continentes.Add("America", paisesAmericanos);

            foreach(string chave in continentes.Keys)
            {
                Console.WriteLine($"Continente: {chave}");
                List<Dictionary<string, double>> continente = continentes[chave];
                double somaPopulacaoTotal = 0;
                for(int i = 0; i < continente.Count; i++ )
                {
                    Dictionary<string , double> pais = continente[i];
                    foreach(KeyValuePair<string, double> paisInfo in pais)
                    {
                        Console.WriteLine($"{paisInfo.Key} - População: {paisInfo.Value}");
                        somaPopulacaoTotal += paisInfo.Value;
                    }
                }
                Console.WriteLine($"População total: {somaPopulacaoTotal}");
            }
            //esse foi hard, tive que comentar. descobri 2 formas de inicializar um dicionário já com chaves e valor
            //quebrei cabeça pra entender que os valores do dicionário continentes tinha que ser uma lista
            //a sacada que mais curti foi percorrer os continentes com foreach e continentes.key
        }
    }
}

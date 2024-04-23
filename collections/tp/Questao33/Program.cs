using System.Collections.Generic;
namespace Questao33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //33 – Faça um programa que monte a estrutura abaixo usando Dictionary<> ou SortedList<>:,

            Dictionary<string, List<Dictionary<string, double>>> continentes = new Dictionary<string, List<Dictionary<string, double>>>();

            continentes.Add("America", new List<Dictionary<string, double>>());
            continentes["America"].Add(new Dictionary<string, double>() { { "Brasil", 202656784 } });
            continentes["America"].Add(new Dictionary<string, double>() { { "México", 120286656 } });
            continentes["America"].Add(new Dictionary<string, double>() { { "Estados Unidos", 318892096 } });
            continentes["America"].Add(new Dictionary<string, double>() { { "Guatemala", 17153288 } });
            continentes["America"].Add(new Dictionary<string, double>() { { "Equador", 16904868 } });
            continentes["America"].Add(new Dictionary<string, double>() { { "Colombia", 49084840 } });
            continentes.Add("Ásia", new List<Dictionary<string, double>>());
            continentes["Ásia"].Add(new Dictionary<string, double>() { { "China", 1355692544 } });
            continentes["Ásia"].Add(new Dictionary<string, double> (){ { "Japão", 127103392 } });
            continentes["Ásia"].Add(new Dictionary<string, double> () { { "Rússia", 141722208 } });
            continentes["Ásia"].Add(new Dictionary<string, double>() { { "Tailândia", 68977400 } });
            continentes["Ásia"].Add(new Dictionary<string, double>() { { "Líbano", 5469612 } });
            continentes["Ásia"].Add(new Dictionary<string, double>() { {"Índia", 1326093184} });
            continentes.Add("África", new List<Dictionary<string, double>>());
            continentes["África"].Add(new Dictionary<string, double>() { {"Nigéria", 214028304} });
            continentes["África"].Add(new Dictionary<string, double>() { {"Angola", 32522340} });
            continentes["África"].Add(new Dictionary<string, double>() { {"Egito", 104124440} });
            continentes["África"].Add(new Dictionary<string, double>() { {"África do Sul", 56463616} });
            continentes["África"].Add(new Dictionary<string, double>() { {"Marrocos", 35561656} });

            foreach(string chave in continentes.Keys)
            {
                Console.WriteLine($"Continente: {chave}\n");
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
                Console.WriteLine($"\nPopulação total: {somaPopulacaoTotal}\n");
                Console.WriteLine();
            }
        }
    }
}

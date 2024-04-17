using System.Collections;
namespace Questao19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19 – Crie um dicionário com URL’s e IP’s dos websites abaixo e mais 5 à sua escolha. O seu dicionário deve ser implementado usando a classe Hashtable e terá a URL como chave e o IP correspondente como valor (por exemplo, se digitarmos como chave a URL www.google.com, seu programa deve retornar o IP 74.125.234.81). O seu programa deve permitir que o usuário digite uma URL e deve imprimir o IP correspondente. Para descobrir o IP de um website, basta digitar ping + URL do website (exemplo: ping www.google.com).
            string continua = "s";
            do
            {
                Console.Clear();  
                Hashtable dicWebsite = new Hashtable()
                {
                    {"www.google.com", "142.251.134.132"},
                    {"www.pucminas.br", "200.229.32.28"},
                    {"www.gmail.com", "142.251.129.69"},
                    {"www.youtube.com", "142.250.79.46"},
                    {"www.capes.gov.br", "200.130.18.127"},
                    {"www.yahoo.com", "200.152.164.204"},
                    {"www.microsoft.com", "95.100.209.217"},
                    {"www.twitter.com", "104.244.42.65"},
                    {"www.brasil.gov.br", "170.246.255.242"},
                    {"www.wikipedia.com", "208.80.154.232"},
                    {"www.amazon.com", "108.158.125.45"},
                    {"research.microsoft.com", "20.76.201.171"},
                    {"www.facebook.com", "31.13.90.35"},
                    {"www.whitehouse.gov", "192.0.66.168"},
                    {"www.answers.com", "151.101.248.203"},
                    {"www.uol.com.br", "108.158.122.115"},
                    {"www.hotmail.com", "204.79.197.212"},
                    {"www.cplusplus.com", "54.39.7.252"},
                    {"www.nyt.com", "151.101.249.164"},
                    {"www.apple.com", "95.101.40.246"},
                };
                dicWebsite.Add("www.instagram.com", "31.13.90.174");
                dicWebsite.Add("www.alura.com.br", "104.26.0.170");
                dicWebsite.Add("stackoverflow.com", "172.64.155.249");
                dicWebsite.Add("www.github.com", "20.201.28.151");
                dicWebsite.Add("www.web.dio.me", "18.161.200.126");

                Console.Write("Digite a URL: ");
                string entradaUrl = Console.ReadLine().ToLower();
                if (dicWebsite.ContainsKey(entradaUrl))
                {
                    Console.WriteLine(dicWebsite[entradaUrl]);
                }
                else
                {
                    Console.WriteLine("URL não cadastrada.");
                }

                Console.WriteLine("Deseja continuar a consulta? s/n");
                continua = Console.ReadLine().ToLower();
            } while (continua == "s");
        }
    }
}

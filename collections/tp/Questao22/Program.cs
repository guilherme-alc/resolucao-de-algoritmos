using System.Collections;
namespace Questao22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22 – Faça um programa que cadastre em um Hashtable alguns modelos de carros de montadoras nacionais, conforme a tabela abaixo (você deve fazer esse cadastro internamente, não o usuário – crie uma função para isso). Seu Hashtable tem como chave o nome da montadora, e como valor um Arraylist contendo os modelos de carros da tabela abaixo.
            Hashtable carrosCadastrados = CadastroDeCarros();
            Console.Write("Digite o nome da montadora: ");
            string montadora = Console.ReadLine();
            if(carrosCadastrados.ContainsKey(montadora))
            {
                ArrayList modelos = (ArrayList) carrosCadastrados[montadora];

                Console.WriteLine($"Quantidade de modelos: {modelos.Count}");
                foreach (object modelo in modelos)
                {
                    Console.WriteLine($"- {modelo}");
                }
            } else
            {
                Console.WriteLine("Montadora não existe no sistema");
            }
        }

        static Hashtable CadastroDeCarros()
        {
            Hashtable carros = new Hashtable();
            ArrayList modelosFiat = new ArrayList() {"Mille", "Novo Uno", "Palio", "Siena", "Freemont", "Bravo", "Punto", "Linea", "Palio Weekend"};
            ArrayList modelosVolksagen = new ArrayList() {"Gol", "Voyage", "Polo", "Passat", "Amarok", "Fox", "Golf", "Jetta", "Tiguan"};
            ArrayList modelosFord = new ArrayList() {"Focus", "Fiesta", "Ka", "New Fiesta", "Fusion", "Edge"};
            ArrayList modelosGM = new ArrayList() {"Celta", "Classic", "Prisma", "Agile", "Omega", "Cruze", "Camaro", "Malibu"};
            carros.Add("Fiat", modelosFiat);
            carros.Add("Volksagen", modelosVolksagen);
            carros.Add("Ford", modelosFord);
            carros.Add("GM", modelosGM);
            return carros;
        }
    }
}

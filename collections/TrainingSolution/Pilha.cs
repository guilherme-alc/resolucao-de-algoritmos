using System.Collections;

namespace TrainingSolution
{
    internal class Pilha
    {
        public static void Executar()
        {
            Stack pilhaDeNomes = new Stack();
            string entrada = "";
            Console.WriteLine("Insira alguns nomes na pilha. \"FIM\" termina a execução");
            do
            {
                Console.Write("Nome: ");
                entrada = Console.ReadLine();
                if (entrada != "FIM")
                {
                    pilhaDeNomes.Push(entrada);
                }

            } while (entrada != "FIM");

            Console.WriteLine("\nImprimir usando for:");
            string[] listaDeNomes = (string[]) pilhaDeNomes.ToArray();
            for(int i = 0; i < listaDeNomes.Length; i++)
            {
                Console.WriteLine(listaDeNomes[i]);
            }

            Console.WriteLine("\nImprimir usando foreach:");
            foreach(string nome in pilhaDeNomes) 
            {
                Console.WriteLine(nome);
            }
        }
    }
}

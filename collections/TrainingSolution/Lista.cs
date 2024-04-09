using System.Collections;
namespace TrainingSolution
{
    internal class Lista
    {
        public static void Executar()
        {
            ArrayList listaDeInteiros = new ArrayList();
            Console.WriteLine("Insira 10 números inteiros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: ");
                int entrada;
                if (int.TryParse(Console.ReadLine(), out entrada))
                {
                    listaDeInteiros.Add(entrada);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Insira um número inteiro válido.");
                }
            }
            Console.Clear();
            Console.WriteLine("Imprimindo com for:");
            for (int i = 0; i < listaDeInteiros.Count; i++)
            {
                Console.Write(listaDeInteiros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo com foreach:");
            foreach (object inteiro in listaDeInteiros)
            {
                Console.Write(inteiro + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo com while:");
            int count = 0;
            while (listaDeInteiros.Count > count)
            {
                Console.Write(listaDeInteiros[count] + " ");
                count++;
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo na ordem inversa com for:");
            for (int i = listaDeInteiros.Count - 1; i >= 0; i--)
            {
                Console.Write(listaDeInteiros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo na ordem inversa com recursividade:");
            int tamanho = listaDeInteiros.Count;
            Recursao(listaDeInteiros, tamanho - 1);
            Console.WriteLine();

            Console.WriteLine("\nImprimindo na ordem inversa com foreach:");
            listaDeInteiros.Reverse();
            foreach (object inteiro in listaDeInteiros)
            {
                Console.Write(inteiro + " ");
            }
            Console.WriteLine();
        }

        static void Recursao(ArrayList listaDeInteiros, int tamanho)
        {
            if(tamanho >= 0)
            {
                Console.Write(listaDeInteiros[tamanho] + " ");
                Recursao(listaDeInteiros, tamanho - 1);
            }
        }
    }
}

using System.Collections;

namespace TrainingSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Qual estrutura de dados deseja executar?");
                Console.WriteLine("1 - Lista");
                Console.WriteLine("2 - Queue");
                Console.WriteLine("3 - Stack");
                Console.WriteLine("4 - Hashtable");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "1":
                        Console.Clear();
                        Lista.Executar();
                        Console.WriteLine("\nAperte uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Fila.Executar();
                        Console.WriteLine("\nAperte uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Pilha.Executar();
                        Console.WriteLine("\nAperte uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Dicionario.Executar();
                        Console.WriteLine("\nAperte uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        continuar = false;
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("\nAperta uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

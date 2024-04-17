using System.Collections;
namespace Questao18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Um biólogo precisa de um programa que traduza uma trinca de nucleotídeos em seu aminoácido correspondente. Por exemplo, a trinca de aminoácidos ACG é traduzida como o aminoácido Treonina, e GCA em Alanina. Crie um programa em C# que use um Hashtable para criar um dicionário do código genético. O usuário deve digitar uma trinca (chave) e seu programa deve mostrar o nome (valor) do aminoácido correspondente. Use a tabela abaixo para cadastrar todas as trincas/aminoácidos.
            string continua = "s";
            do
            {
                Console.Clear();
                Hashtable trincasEAminoacidos = new Hashtable()
                {
                    {"UUU", "Fenilalanina"},
                    {"UUC", "Fenilalanina"},
                    {"UUA", "Leucina"},
                    {"UUG", "Leucina"},
                    {"UCU", "Serina"},
                    {"UCC", "Serina"},
                    {"UCA", "Serina"},
                    {"UCG", "Serina"},
                    {"UAU", "Tirosina"},
                    {"UAC", "Tirosina"},
                    {"UAA", "Parada"},
                    {"UAG", "Parada"},
                    {"UGU", "Cisteína"},
                    {"UGC", "Cisteína"},
                    {"UGA", "Parada"},
                    {"UGG", "Triptofano"},
                    {"CUU", "Leucina"},
                    {"CUC", "Leucina"},
                    {"CUA", "Leucina"},
                    {"CUG", "Leucina"},
                    {"CCU", "Prolina"},
                    {"CCC", "Prolina"},
                    {"CCA", "Prolina"},
                    {"CCG", "Prolina"},
                    {"CAU", "Histidina"},
                    {"CAC", "Histidina"},
                    {"CAA", "Glutamina"},
                    {"CAG", "Glutamina"},
                    {"CGU", "Arginina"},
                    {"CGC", "Arginina"},
                    {"CGA", "Arginina"},
                    {"CGG", "Arginina"},
                    {"AUU", "Isoleucina"},
                    {"AUC", "Isoleucina"},
                    {"AUA", "Isoleucina"},
                    {"AUG", "Metionina"},
                    {"ACU", "Treonina"},
                    {"ACC", "Treonina"},
                    {"ACA", "Treonina"},
                    {"ACG", "Treonina"},
                    {"AAU", "Asparagina"},
                    {"AAC", "Asparagina"},
                    {"AAA", "Lisina"},
                    {"AAG", "Lisina"},
                    {"AGU", "Serina"},
                    {"AGC", "Serina"},
                    {"AGA", "Arginina"},
                    {"AGG", "Arginina"},
                    {"GUU", "Valina"},
                    {"GUC", "Valina"},
                    {"GUA", "Valina"},
                    {"GUG", "Valina"},
                    {"GCU", "Alanina"},
                    {"GCC", "Alanina"},
                    {"GCA", "Alanina"},
                    {"GCG", "Alanina"},
                    {"GAU", "Aspartato"},
                    {"GAC", "Aspartato"},
                    {"GAA", "Glutamato"},
                    {"GAG", "Glutamato"},
                    {"GGU", "Glicina"},
                    {"GGC", "Glicina"},
                    {"GGA", "Glicina"},
                    {"GGG", "Glicina"},
                };

                Console.Write("Digite a trinca: ");
                string entradaTrinca = Console.ReadLine().ToUpper();

                if (trincasEAminoacidos.ContainsKey(entradaTrinca))
                    Console.WriteLine("Aminoácido: " + trincasEAminoacidos[entradaTrinca]);
                else
                    Console.WriteLine("Essa trinca não existe no dicionário");

                Console.WriteLine("Deseja continuar a consulta? s/n");
                continua = Console.ReadLine().ToLower();
            } while (continua == "s");
        }
    }
}

using System.Collections;
using System.ComponentModel.Design;
namespace Questao21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21 – Faça um programa que use um SortedList para adicionar a matrícula (key) e nome (value) de vários alunos. Para encerrar o cadastramento de alunos, o usuário deve digitar uma matrícula negativa. Após o cadastro, seu programa deve permitir ao usuário pesquisar alunos através de sua matrícula. O usuário deve digitar um número negativo para interromper a pesquisa.
            SortedList alunos = new SortedList();
            string opcao = "1";
            do
            {
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Pesquisar aluno");
                Console.WriteLine("0 - Encerrar programa");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastroDeAluno(ref alunos);
                        break;
                    case "2":
                        PesquisaDeAluno(alunos);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != "0");

        }

        static void CadastroDeAluno(ref SortedList alunos)
        {
            int matricula = 1;
            Console.Clear();
            Console.WriteLine("Cadastro de matrícula. Numeros negativos encerram o cadastro");
            do
            {
                Console.Write("Digite o número da matrícula: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out matricula))
                {
                    if(matricula >= 0)
                    {
                        Console.Write("Digite o nome do aluno: ");
                        string nome = Console.ReadLine();
                        alunos.Add(matricula, nome);
                        Console.WriteLine($"Aluno {nome} foi cadastrado!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Matrícula inválida");
                }
            } while (matricula >= 0);
        }

        static void PesquisaDeAluno(SortedList alunos)
        {
            Console.Clear();
            if(alunos.Count > 0)
            {
                int matricula = 1;
                Console.WriteLine("Digite a matrícula do aluno ou algum número negativo para encerrar a busca");
                do
                {
                    matricula = int.Parse(Console.ReadLine());
                    if (alunos.ContainsKey(matricula) && matricula >= 0)
                    {
                        Console.WriteLine($"Aluno: {alunos[matricula]} | Matricula: {matricula}");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontado.");
                    }
                } while (matricula >= 0);
            } else
            {
                Console.WriteLine("Não existe alunos cadastrados");
            }
        }
    }
}

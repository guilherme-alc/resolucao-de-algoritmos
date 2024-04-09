using System.Collections;
namespace TrainingSolution
{
    internal class Dicionario
    {
        public static void Executar()
        {
            Hashtable listaDeProdutos = new Hashtable();
            bool continua = true;
            while(continua)
            {
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Pesquisar produto");
                Console.WriteLine("3 - Voltar ao menu inicial");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarProduto(ref listaDeProdutos);
                        break;
                    case "2":
                        PesquisarProduto(ref listaDeProdutos);
                        break;
                    case "3":
                        continua = false;
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
        }
        static void CadastrarProduto(ref Hashtable listaDeProdutos)
        {
            Console.Clear();
            Console.WriteLine("Cadastro de produtos:");
            Console.WriteLine("Digite o nome do produto e o valor seperado por um espaço. Ex: Amaciante 22,00\n\"FIM\" termina o cadastro.\n");
            bool repeticao = true;
            do
            {
                string[] entrada = Console.ReadLine().Split(" ");
                if (entrada[0] != "FIM")
                {
                    string produto = entrada[0];
                    decimal valor = Convert.ToDecimal(entrada[1]);
                    listaDeProdutos.Add(produto, valor);
                }
                else
                {
                    repeticao = false;
                }
            } while (repeticao);

            Console.WriteLine("\nProdutos cadastrados: ");
            foreach (DictionaryEntry produto in listaDeProdutos)
            {
                Console.WriteLine($"{produto.Key} - R$ {produto.Value}");
            }
        }

        static void PesquisarProduto(ref Hashtable listaDeProdutos)
        {
            Console.Clear();
            if (listaDeProdutos.Count > 0)
            {
                Console.WriteLine("Qual produto deseja pesquisar?\n\"FIM\" encerra a pesquisa.");
                string produto = "";
                do
                {
                    Console.Write("\nProduto: ");
                    produto = Console.ReadLine();
                    if (listaDeProdutos.ContainsKey(produto) && produto != "FIM")
                    {
                        Console.WriteLine($"Preço do produto é: {listaDeProdutos[produto]}");
                    } else if (produto == "FIM")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Esse produto não está cadastrado");
                    }

                } while (produto != "FIM");
            }
            else
            {
                Console.WriteLine("Não há nenhum produto cadastrado");
            }
        }
    }
}

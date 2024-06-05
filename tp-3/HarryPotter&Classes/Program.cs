using HarryPotter_Classes.Models;
using HarryPotter_Classes.DataStructures;

namespace HarryPotter_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();
        }
    }
    internal class Sistema
    {
        private CLista lista;
        private CFila fila;
        private CPilha pilha;
        private Personagem[] vetorPersonagens;
        public Sistema()
        {
            vetorPersonagens = ConstroiPersonagem();
            lista = new CLista();
            fila = new CFila();
            pilha = new CPilha();
            ExecutaComandos();
        }
        private Personagem[] ConstroiPersonagem()
        {
            Console.WriteLine("Quantos personagens deseja criar?");
            int qtdPersonagens = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nDigite as informações do personagem na seguinte estrutura:");
            //Console.WriteLine("IdPersonagem;Nome;Casa;Origem;Ator/Atriz;EstaVivo;AnoNascimento;CorDosOlhos;Sexo;CorDoCabelo;ÉBruxo");
            //Console.WriteLine("Estrutura Exemplo:");
            //Console.WriteLine("d5c4daa3-c726-426a-aa98-fb40f3fba816;Cedric Diggory;Lufa-Lufa;mestiço;Robert Pattinson;False;1977;cinza;masculino;castanhos;True");
            Personagem[] vetorTemp = new Personagem[qtdPersonagens];
            for(int i = 0; i < qtdPersonagens; i++)
            {
                Console.WriteLine("\nPersonagem:");
                string [] dadosPersonagem = Console.ReadLine().Split(';');
                vetorTemp[i] = new Personagem(dadosPersonagem);
            }
            return vetorTemp;                
        } 
        private void ExecutaComandos()
        {
            Console.Clear();
            Console.WriteLine("Quantos comandos deseja executar?");
            int qtdComandos = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nOs comandos se baseiam em instrução;parâmetro.\n");
            //Console.WriteLine("- Para inserir dados na estruturas utilize as instruções Enfi, Empi, InsFim, InsIni com um ano como parâmetro. Ex. Empi;1954 (vai empilhar todos os personagems que nasceram em 1954)");
            //Console.WriteLine("- Para remover dados nas estruturas utilize as instruções Desempi, Desenfi, RemComec, RemFim com uma quantidade como parâmetro ou all para remover tudo. Ex: Desempi;2 , Desenfi;all");
            //Console.WriteLine("- Para consultar se a estrutura possui um personagem utilize TemCPil e TemCFil com o nome do personagem como parâmetro. Ex: TemCFil;Draco Malfoy");
            for(int i = 0; i < qtdComandos; i++)
            {
                Console.WriteLine("Digite o comando:");
                string[] comando = Console.ReadLine().Split(';');
                string instrucao = comando[0];
                string parametro = comando[1];
                switch(instrucao)
                {
                    case "Empi":
                        EmpilharPersonagem(parametro);
                        break;
                    case "Desempi":
                        DesempilharPersonagem(parametro);
                        break;
                    case "TemCPil":
                        ContemPersonagemPilha(parametro);
                        break;
                    case "Enfi":
                        EnfileirarPersonagem(parametro);
                        break;
                    case "Desenfi":
                        DesenfilerarPersonagem(parametro);
                        break;
                    case "TemCFil":
                        ContemPersonagemFila(parametro);
                        break;
                    case "InsIni":
                        InsereInicioLista(parametro);
                        break;
                    case "InsFim":
                        InsereFimLista(parametro);
                        break;
                    case "RemIni":
                        RemoveInicioLista(parametro);
                        break;
                    case "RemFim":
                        RemoveInicioLista(parametro);  
                        break;
                    default:
                        Console.WriteLine("Tipo de comando inválido");
                        break;
                }
            }
        }
        public void EmpilharPersonagem (string parametro)
        {
            int ano = int.Parse(parametro);
            for (int j = 0; j < vetorPersonagens.Length; j++)
            {
                if (vetorPersonagens[j].getAnoNascimento(parametro))
                {
                    pilha.Empi(vetorPersonagens[j]);
                }
            }
        }
        public void DesempilharPersonagem (string parametro)
        {
            int quantidade = parametro == "all" ? pilha.Count() : int.Parse(parametro);
            if (quantidade <= pilha.Count())
            {
                for (int j = 0; j < quantidade && pilha.Count() > 0; j++)
                {
                    Personagem pRemovido = pilha.Desempi();
                    Console.WriteLine(pRemovido.ToString());
                }
            }
        }
        public void ContemPersonagemPilha (string parametro)
        {
            if(pilha.TemCPil(parametro))
            {
                Console.WriteLine($"{parametro} Ok");
            } else
            {
                Console.WriteLine($"{parametro} Nada");

            }
        }
        public void EnfileirarPersonagem (string parametro)
        {
            int ano = int.Parse(parametro);
            for(int j = 0; j < vetorPersonagens.Length; j++)
            {
                if (vetorPersonagens[j].getAnoNascimento(parametro))
                {
                    fila.Enfi(vetorPersonagens[j]);
                }
            }

        }
        public void DesenfilerarPersonagem (string parametro)
        {
            int quantidade = parametro == "all" ? fila.Count() : int.Parse(parametro);
            if(quantidade <= fila.Count())
            {
                for(int j = 0; j < quantidade && fila.Count() > 0; j++)
                {
                    Personagem pRemovido = fila.Desenfi();
                    Console.WriteLine(pRemovido.ToString());
                }
            }
        }
        public void ContemPersonagemFila(string parametro)
        {
            if(fila.TemCFil(parametro))
            {
                Console.WriteLine($"{parametro} Ok");
            }
            else
            {
                Console.WriteLine($"{parametro} Nada");

            }
        }
        public void InsereInicioLista(string parametro)
        {
            int ano = int.Parse(parametro);
            for (int j = 0; j < vetorPersonagens.Length; j++)
            {
                if (vetorPersonagens[j].getAnoNascimento(parametro))
                {
                    lista.InsIni(vetorPersonagens[j]);
                }
            }
        }
        public void InsereFimLista(string parametro)
        {
            int ano = int.Parse(parametro);
            for (int j = 0; j < vetorPersonagens.Length; j++)
            {
                if (vetorPersonagens[j].getAnoNascimento(parametro))
                {
                    lista.InsFim(vetorPersonagens[j]);
                }
            }
        }
        public void RemoveInicioLista(string parametro)
        {
            int quantidade = parametro == "all" ? lista.Count() : int.Parse(parametro);
            if (quantidade <= lista.Count())
            {
                for (int j = 0; j < quantidade && lista.Count() > 0; j++)
                {
                    Personagem pRemovido = lista.RemIni();
                    Console.WriteLine(pRemovido.ToString());
                }
            }
        }
        public void RemoveFimLista(string parametro)
        {
            int quantidade = parametro == "all" ? lista.Count() : int.Parse(parametro);
            if (quantidade <= lista.Count())
            {
                for (int j = 0; j < quantidade && lista.Count() > 0; j++)
                {
                    Personagem pRemovido = lista.RemFim();
                    Console.WriteLine(pRemovido.ToString());
                }
            }
        }
    }
}


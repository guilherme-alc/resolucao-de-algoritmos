using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Personagem [] vetorPersonagens = ConstroiPersonagem();
        List<Personagem> lista = new List<Personagem>();
        Queue<Personagem> fila = new Queue<Personagem>();
        Stack<Personagem> pilha = new Stack<Personagem>();
        ExecutaComando(vetorPersonagens, lista, fila, pilha);
    }
    public static Personagem [] ConstroiPersonagem ()
    {
        int qtdPersonagens = int.Parse(Console.ReadLine());
        Personagem [] vetorTemp = new Personagem [qtdPersonagens];
        for (int i = 0; i < qtdPersonagens; i++)
        {
            string[] constroiPersonagem = Console.ReadLine().Split(";");
            Personagem personagem = new Personagem (constroiPersonagem);
            vetorTemp[i] = personagem;
        }
        return vetorTemp;
    }

    public static void ExecutaComando (Personagem [] vetorPersonagens, List<Personagem> lista, Queue<Personagem> fila, Stack<Personagem> pilha)
    {
        int qtdComandos = int.Parse(Console.ReadLine());
        for (int j = 0; j < qtdComandos; j++)
        {
            string[] comando = Console.ReadLine().Split(";");
            string instrucao = comando[0];
            string parametro = comando[1];
            switch(instrucao)
            {
                case "Empi":
                    break;
                case "Enfi":
                    break;
                case "InsIni":
                    break;
                case "InsFim":
                    break;
                case "Desempi":
                    int quantidade = parametro == "all" ? lista.Count : int.Parse(parametro);
                    break;
                case "Desenfi":
                    break;
                case "RemComec":
                    break;
                case "RemFim":
                    break;
                case "TemCPil":
                    break;
                case "TemCFil":
                    break;
                default:
                    break;
            }
        }
    }
}
internal class Personagem
{
    public Personagem(string [] personagemInfo)
    {
        idPersonagem = personagemInfo[0];
        nome = personagemInfo[1];
        nomeDaCasa = personagemInfo[2];
        origem = personagemInfo[3];
        atorAtriz = personagemInfo[4];
        estaVivo = bool.Parse(personagemInfo[5]);
        anoNascimento = int.Parse(personagemInfo[6]);
        corOlhos = personagemInfo[7];
        sexo = personagemInfo[8];
        corCabelo = personagemInfo[9];
        bruxo = bool.Parse(personagemInfo[10]);
    }
    private string idPersonagem;
    private string nome;
    private string nomeDaCasa;
    private string origem;
    private string atorAtriz;
    private bool estaVivo;
    private int anoNascimento;
    private string corOlhos;
    private string sexo;
    private string corCabelo;
    private bool bruxo;

    public override string ToString ()
    {
        return $"{idPersonagem};{nome};{nomeDaCasa};{origem};{atorAtriz};{estaVivo};{anoNascimento};{corOlhos};{sexo};{corCabelo};{bruxo}";
    }

    public bool ConsultaNome (string nome)
    {
        if (this.nome != nome) 
        {
            return false;
        }
        return true;
    }
}

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

internal class CCelula
{
    public Object Item;
    public CCelula Prox;
    public CCelula ()
    {
        Item = null;
        Prox = null;
    }
    public CCelula(Object valorItem)
    {
        Item = valorItem;
        Prox = null;
    }
    public CCelula(Object valorItem, CCelula valorProx)
    {
        Item = valorItem;
        Prox = valorProx;
    }
}

internal class CFila
{
    private CCelula Frente;
    private CCelula Tras;
    private int Qtd = 0;
    public CFila()
    {
        Frente = new CCelula();
        Tras = Frente;
    }
    public void Enqueue (object item)
    {
        Tras.Prox = new CCelula(item);
        Tras = Tras.Prox;
        Qtd++;
    }
    public object Dequeue ()
    {
        Object item = null;
        if(Frente != Tras)
        {
            Frente = Frente.Prox;
            item = Frente.Item;
            Qtd--;
        }
        return item;
    }
    public bool IsEmpty ()
    {
        return Frente == Tras;
    }
    public object Peek()
    {
        if(Frente != Tras)
        {
            return Frente.Prox.Item;
        } else
        {
            return null;
        }
    }
    public bool Contains (object ValorItem)
    {
        bool contem = false;
        CCelula aux = Frente.Prox;
        while (aux != null && !contem)
        {
            contem = aux.Item.Equals(ValorItem);
            aux = aux.Prox;
        }
        return contem;
    }

    public bool ContainsWithFor(Object ValorItem)
    {
        bool contem = false;
        for (CCelula aux = Frente.Prox; aux != null && !contem; aux = aux.Prox)
            contem = aux.Item.Equals(ValorItem);
        return contem;
    }

    public int Count ()
    {
        return Qtd;
    }

    public void Print()
    {
        Console.Write("[ ");
        for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
            Console.Write(aux.Item + " ");
        Console.WriteLine("]");
    }
}

internal class CPilha
{
    public CCelula Topo = null;
    private int _count = 0;
    public CPilha()
    {

    }
    public void Push (Object item)
    {
        Topo = new CCelula(item, Topo);
        _count++;
    }
    public object Pop ()
    {
        Object item = null;
        if(Topo != null)
        {
            item = Topo.Item;
            Topo = Topo.Prox;
            _count--;
        }
        return item;
    }
    public bool IsEmpty()
    {
        return Topo == null;
    }
    public bool Contains (Object item)
    {
        bool contem = false;
        CCelula aux = Topo;

        while(aux != null && !contem)
        {
            contem = aux.Item.Equals(item);
            aux = aux.Prox;
        }

        return contem;
    }
    public bool ContainsWithFor(Object item)
    {
        bool contem = false;
        for(CCelula aux = Topo; aux != null && !contem; aux = aux.Prox)
        {
            contem = aux.Item.Equals(item);
        }
        return contem;
    }
    public object Peek()
    {
        if(Topo != null)
        {
            return Topo.Item;
        }
        else
        {
            return null;
        }
    }
    public int Count()
    {
        return _count;
    }
}

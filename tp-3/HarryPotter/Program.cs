using System;
internal class Program
{
    static void Main(string[] args)
    {
        Personagem [] vetorPersonagens = ConstroiPersonagem();
        CLista lista = new CLista();
        CFila fila = new CFila();
        CPilha pilha = new CPilha();
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

    public static void ExecutaComando(Personagem[] vetorPersonagens, CLista lista, CFila fila, CPilha pilha)
    {
        int qtdComandos = int.Parse(Console.ReadLine());
        for (int j = 0; j < qtdComandos; j++)
        {
            string[] comando = Console.ReadLine().Split(";");
            string instrucao = comando[0];
            string parametro = comando[1];
            switch (instrucao)
            {
                case "Empi":
                    for (int i = 0; i < vetorPersonagens.Length; i++)
                    {
                        if (vetorPersonagens[i].ConsultaIdade(parametro))
                        {
                            pilha.Empi(vetorPersonagens[i]);
                        }
                    }
                    break;
                case "Enfi":
                    for (int i = 0; i < vetorPersonagens.Length; i++)
                    {
                        if (vetorPersonagens[i].ConsultaIdade(parametro))
                        {
                            fila.Enfi(vetorPersonagens[i]);
                        }
                    }
                    break;
                case "InsIni":
                    for (int i = 0; i < vetorPersonagens.Length; i++)
                    {
                        if (vetorPersonagens[i].ConsultaIdade(parametro))
                        {
                            lista.InsIni(vetorPersonagens[i]);
                        }
                    }
                    break;
                case "InsFim":
                    for (int i = 0; i < vetorPersonagens.Length; i++)
                    {
                        if (vetorPersonagens[i].ConsultaIdade(parametro))
                        {
                            lista.InsFim(vetorPersonagens[i]);
                        }
                    }
                    break;
                case "Desempi":
                    pilha.Desempi(parametro);
                    break;
                case "Desenfi":
                    fila.Desenfi(parametro);
                    break;
                case "RemComec":
                    lista.RemComec(parametro);
                    break;
                case "RemFim":
                    lista.RemFim(parametro);
                    break;
                case "TemCPil":
                    pilha.TemCPil(parametro);
                    break;
                case "TemCFil":
                    fila.TemCFil(parametro);
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

    public bool ConsultaIdade (string anoNascimento)
    {
        if(this.anoNascimento != int.Parse(anoNascimento))
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
    private int _qtd = 0;

    public CFila()
    {
        Frente = new CCelula();
        Tras = Frente;
    }

    public void Enfi(object item)
    {
        Tras.Prox = new CCelula(item);
        Tras = Tras.Prox;
        _qtd++;
    }

    public void Desenfi(string parametro)
    {
        Object item = null;
        if (Frente != Tras)
        {
            if (parametro.Equals("all"))
            {
                while (Frente.Prox != null)
                {
                    Frente = Frente.Prox;
                    item = Frente.Item;
                    Console.WriteLine(item.ToString());
                    _qtd--;
                }
                Tras = Frente;
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && Frente != Tras)
                {
                    Frente = Frente.Prox;
                    item = Frente.Item;
                    Console.WriteLine(item.ToString());
                    _qtd--;
                    quantidade--;
                }
                if (Frente == Tras)
                {
                    Tras = Frente;
                }
            }
        }
    }

    public void TemCFil(string nome)
    {
        bool contem = false;
        CCelula aux = Frente.Prox;
        Personagem personagem;
        while (aux != null && !contem)
        {
            personagem = (Personagem)aux.Item;
            contem = personagem.ConsultaNome(nome);
            aux = aux.Prox;
        }
        if (contem)
        {
            Console.WriteLine($"{nome} Ok");
        }
        else
        {
            Console.WriteLine($"{nome} Nada");
        }
    }

    public bool ContainsWithFor(Object ValorItem)
    {
        bool contem = false;
        for (CCelula aux = Frente.Prox; aux != null && !contem; aux = aux.Prox)
            contem = aux.Item.Equals(ValorItem);
        return contem;
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

    public CPilha() { }

    public void Empi(Object item)
    {
        Topo = new CCelula(item, Topo);
        _count++;
    }

    public void Desempi(string parametro)
    {
        Object item = null;
        if (Topo != null)
        {
            if (parametro.Equals("all"))
            {
                while (Topo != null)
                {
                    item = Topo.Item;
                    Console.WriteLine(item.ToString());
                    Topo = Topo.Prox;
                    _count--;
                }
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && Topo != null)
                {
                    item = Topo.Item;
                    Console.WriteLine(item.ToString());
                    Topo = Topo.Prox;
                    _count--;
                    quantidade--;
                }
            }
        }
    }

    public void TemCPil(string nome)
    {
        bool contem = false;
        CCelula aux = Topo;
        Personagem personagem;

        while(aux != null && !contem)
        {
            personagem = (Personagem)aux.Item;
            contem = personagem.ConsultaNome(nome);
            aux = aux.Prox;
        }
        if (contem)
        {
            Console.WriteLine($"{nome} Ok");
        }
        else
        {
            Console.WriteLine($"{nome} Nada");
        }
    }

    public bool ContainsWithFor(Object item)
    {
        bool contem = false;
        for (CCelula aux = Topo; aux != null && !contem; aux = aux.Prox)
        {
            contem = aux.Item.Equals(item);
        }
        return contem;
    }
}

internal class CLista
{
    public CCelula Primeira;
    public CCelula Ultima;
    private int _qtd = 0;

    public CLista()
    {
        Primeira = new CCelula();
        Ultima = Primeira;
    }

    public void InsIni(Object item)
    {
        CCelula nova = new CCelula(item, Primeira.Prox);
        Primeira.Prox = nova;
        if (Ultima == Primeira)
        {
            Ultima = nova;
        }
        _qtd++;
    }

    public void InsFim(Object item)
    {
        Ultima.Prox = new CCelula(item);
        Ultima = Ultima.Prox;
        _qtd++;
    }

    public void RemFim(string parametro)
    {
        if (Primeira != Ultima)
        {
            if (parametro.Equals("all"))
            {
                while (Primeira != Ultima)
                {
                    CCelula aux = Primeira;
                    while (aux.Prox != Ultima)
                    {
                        aux = aux.Prox;
                    }
                    Console.WriteLine(Ultima.Item.ToString());
                    Ultima = aux;
                    Ultima.Prox = null;
                    _qtd--;
                }
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && _qtd > 0)
                {
                    CCelula aux = Primeira;
                    while (aux.Prox != Ultima)
                    {
                        aux = aux.Prox;
                    }
                    Console.WriteLine(Ultima.Item.ToString());
                    Ultima = aux;
                    Ultima.Prox = null;
                    _qtd--;
                    quantidade--;
                }
            }
        }
    }

    public void RemComec(string parametro)
    {
        if (Primeira != Ultima)
        {
            if (parametro.Equals("all"))
            {
                while (Primeira != Ultima)
                {
                    Primeira = Primeira.Prox;
                    Console.WriteLine(Primeira.Item.ToString());
                    _qtd--;
                }
                Ultima = Primeira;
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && Primeira != Ultima)
                {
                    Primeira = Primeira.Prox;
                    Console.WriteLine(Primeira.Item.ToString());
                    _qtd--;
                    quantidade--;
                }
                if (Primeira == Ultima)
                {
                    Ultima = Primeira;
                }
            }
        }
    }
}


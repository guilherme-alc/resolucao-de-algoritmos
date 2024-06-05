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
    private CCelula frente;
    private CCelula tras;
    private int qtd = 0;

    public CFila()
    {
        frente = new CCelula();
        tras = frente;
    }

    public void Enfi(object item)
    {
        tras.Prox = new CCelula(item);
        tras = tras.Prox;
        qtd++;
    }

    public void Desenfi(string parametro)
    {
        Object item = null;
        if (frente != tras)
        {
            if (parametro.Equals("all"))
            {
                while (frente.Prox != null)
                {
                    frente = frente.Prox;
                    item = frente.Item;
                    Console.WriteLine(item.ToString());
                    qtd--;
                }
                tras = frente;
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && frente != tras && quantidade < qtd)
                {
                    frente = frente.Prox;
                    item = frente.Item;
                    Console.WriteLine(item.ToString());
                    qtd--;
                    quantidade--;
                }
                if (frente == tras)
                {
                    tras = frente;
                }
            }
        }
    }

    public void TemCFil(string nome)
    {
        bool contem = false;
        CCelula aux = frente.Prox;
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
}


internal class CPilha
{
    private CCelula topo = null;
    private int qtde = 0;

    public CPilha() { }

    public void Empi(Object item)
    {
        topo = new CCelula(item, topo);
        qtde++;
    }

    public void Desempi(string parametro)
    {
        Object item = null;
        if (topo != null)
        {
            if (parametro.Equals("all"))
            {
                while (topo != null)
                {
                    item = topo.Item;
                    Console.WriteLine(item.ToString());
                    topo = topo.Prox;
                    qtde--;
                }
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && topo != null && quantidade < qtde)
                {
                    item = topo.Item;
                    Console.WriteLine(item.ToString());
                    topo = topo.Prox;
                    qtde--;
                    quantidade--;
                }
            }
        }
    }

    public void TemCPil(string nome)
    {
        bool contem = false;
        CCelula aux = topo;
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
}

internal class CLista
{
    private CCelula primeira;
    private CCelula ultima;
    private int qtd = 0;

    public CLista()
    {
        primeira = new CCelula();
        ultima = primeira;
    }

    public void InsIni(Object item)
    {
        CCelula nova = new CCelula(item, primeira.Prox);
        primeira.Prox = nova;
        if (ultima == primeira)
        {
            ultima = nova;
        }
        qtd++;
    }

    public void InsFim(Object item)
    {
        ultima.Prox = new CCelula(item);
        ultima = ultima.Prox;
        qtd++;
    }

    public void RemFim(string parametro)
    {
        if (primeira != ultima)
        {
            if (parametro.Equals("all"))
            {
                while (primeira != ultima)
                {
                    CCelula aux = primeira;
                    while (aux.Prox != ultima)
                    {
                        aux = aux.Prox;
                    }
                    Console.WriteLine(ultima.Item.ToString());
                    ultima = aux;
                    ultima.Prox = null;
                    qtd--;
                }
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && qtd > 0)
                {
                    CCelula aux = primeira;
                    while (aux.Prox != ultima)
                    {
                        aux = aux.Prox;
                    }
                    Console.WriteLine(ultima.Item.ToString());
                    ultima = aux;
                    ultima.Prox = null;
                    qtd--;
                    quantidade--;
                }
            }
        }
    }

    public void RemComec(string parametro)
    {
        if (primeira != ultima)
        {
            if (parametro.Equals("all"))
            {
                while (primeira != ultima)
                {
                    primeira = primeira.Prox;
                    Console.WriteLine(primeira.Item.ToString());
                    qtd--;
                }
                ultima = primeira;
            }
            else
            {
                int quantidade = int.Parse(parametro);
                while (quantidade > 0 && primeira != ultima)
                {
                    primeira = primeira.Prox;
                    Console.WriteLine(primeira.Item.ToString());
                    qtd--;
                    quantidade--;
                }
                if (primeira == ultima)
                {
                    ultima = primeira;
                }
            }
        }
    }
}


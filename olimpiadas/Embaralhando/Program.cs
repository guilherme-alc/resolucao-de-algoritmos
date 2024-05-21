namespace Embaralhando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            while(entrada != "0")
            {
                entrada = Console.ReadLine();
                if(entrada != "0" && entrada.Length <= 15)
                {
                    char[] caractere = new char[entrada.Length];
                    char[] caractereNaoRepetido = new char[entrada.Length]; 
                    int count = 0;
                    for(int j = 0; j < caractere.Length; j++)
                    {
                        caractere[j] = entrada[j];
                    }
                    for(int y = 0;  y < entrada.Length; y++)
                    {
                        for(int x = 0; x < entrada.Length; x++)
                        {
                            if (caractere[x] != entrada[y])
                            {
                                caractereNaoRepetido[y] = entrada[y];
                            }
                        }
                    }
                    foreach(char c in caractereNaoRepetido) 
                    {
                        Console.WriteLine(c);
                    }
                    int fatorial = entrada.Length;
                    int resultado = 0;
                    for(int i = fatorial - 1; i >= 1; i--)
                    {
                        if(i == fatorial -1)
                        {
                            resultado = fatorial * i;
                        } else
                        {
                            resultado *= i; 
                        }
                    }
                    Console.WriteLine(resultado);
                }
            }
        }
    }
}

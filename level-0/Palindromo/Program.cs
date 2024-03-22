using System;
class Program
{
    static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        while (palavra != "FIM")
        {
            if (Metodo(palavra))
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NAO");
            }
            palavra = Console.ReadLine();
        }
    }

    static bool Metodo(string palavra)
    {
        bool palin = false;
        for (int i = 0; i < palavra.Length / 2; i++)
        {
            if (palavra[i] != palavra[palavra.Length - 1 - i])
            {
                return false;
            }
            else
            {
                palin = true;
            }
        }
        return palin;
    }

}
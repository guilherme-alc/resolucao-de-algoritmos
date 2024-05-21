namespace Fliper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] entrada = Console.ReadLine().Split(' ');
            string P = entrada[0]; 
            string R = entrada[1];
            char caminho = ' ';
            if((P == "0" || P == "1") &&  (R == "0" || R == "1")) 
            {
                if(P == "0")
                {
                    caminho = 'C';
                } else if (P == "1" && R == "0") 
                {
                    caminho = 'B';
                } else if(P == "1" && R == "1")
                {
                    caminho = 'A';
                }
                Console.WriteLine(caminho);
            }
        }
    }
}

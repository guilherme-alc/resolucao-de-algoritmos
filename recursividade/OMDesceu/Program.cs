namespace OMDesceu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdLinhas = int.Parse(Console.ReadLine());
            Recursividade(qtdLinhas);
        }

        public static void Recursividade(int n)
        {
            if(n > 0)
            {
                string[] entrada = Console.ReadLine().Split(" ");
                int x = int.Parse(entrada[0]);
                int y = int.Parse(entrada[1]);
                Console.WriteLine(MDC(x,y));
                Recursividade(n - 1);

            }
        }

        public static int MDC(int x, int y)
        {
            
            if(x  > y)
            {
                return MDC(x - y, y);
            } else if (x < y)
            {
                return MDC(y, x);
            }
            return x;
        }
    }
}

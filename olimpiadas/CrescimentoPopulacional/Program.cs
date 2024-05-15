namespace CrescimentoPopulacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdCasoTeste = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtdCasoTeste; i++)
            {
                string [] entrada = Console.ReadLine().Split(' ');
                int PA = int.Parse(entrada[0]);
                int PB = int.Parse(entrada[1]);
                double G1 = double.Parse(entrada[2])/100;
                double G2 = double.Parse(entrada[3])/100;
                int anos = 0;
                while (PA <= PB)
                {
                    PA += (int) (PA * G1);
                    PB += (int) (PB * G2);
                    anos++;
                }
                if(anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                } else
                {
                    Console.WriteLine(anos + " anos.");
                }
            }

        }
    }
}

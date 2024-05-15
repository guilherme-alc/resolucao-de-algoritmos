namespace JogoDoMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            do
            {
                int qtdCasosTeste = int.Parse(Console.ReadLine());
                if( qtdCasosTeste > 0 && qtdCasosTeste <= 10)
                {
                    int pontoA = 0;
                    int pontoB = 0;
                    for (int i = 0; i < qtdCasosTeste; i++)
                    {
                        string[] entrada = Console.ReadLine().Split(' ');
                        int A = int.Parse(entrada[0]);
                        int B = int.Parse(entrada[1]);
                        if ((A >= 0 && A <= 10) && (B >= 0 && B <= 10))
                        {
                            if (A > B)
                            {
                                pontoA++;
                            }
                            else if (B > A)
                            {
                                pontoB++;
                            }
                            else
                            {
                                pontoA += 0;
                                pontoB += 0;
                            }
                        }
                    }
                    Console.WriteLine(pontoA + " " + pontoB);
                } else
                {
                    continua = false;
                }
            } while (continua);
        }
    }
}

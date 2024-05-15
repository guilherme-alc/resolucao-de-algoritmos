namespace MultiplosDe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < num1)
            {
                int aux = num2;
                num2 = num1;
                num1 = aux;
            }
            int soma = 0;
            for(int i = num1; i <= num2; i++)
            {
                if(i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}

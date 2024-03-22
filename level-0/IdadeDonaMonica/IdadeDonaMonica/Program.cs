using System;
class Program
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = m - (a + b);
        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
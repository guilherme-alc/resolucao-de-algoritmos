using System;
class Program
{
    static void Main(string[] args)
    {
        int numTriangulo = int.Parse(Console.ReadLine());
        for (int i = 0; i < numTriangulo; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);
            int c = int.Parse(entrada[2]);

            if (a + b > c && a + c > b && c + b > a)
            {
                a *= a;
                b *= b;
                c *= c;
                int hipotenusa;
                int somaCatetos;
                if(a > b && a > c)
                {
                    hipotenusa = a;
                    somaCatetos = b + c;
                } else if (b > a && b > c)
                {
                    hipotenusa = b;
                    somaCatetos = a + c;
                } else
                {
                    hipotenusa = c;
                    somaCatetos = a + b;
                }

                if (hipotenusa == somaCatetos)
                {
                    Console.WriteLine("r");
                }
                else if (hipotenusa > somaCatetos)
                {
                    Console.WriteLine("o");
                }
                else if (hipotenusa < somaCatetos)
                {
                    Console.WriteLine("a");
                }
            }
            else
            {
                Console.WriteLine("n");
            }
        }

    }
}

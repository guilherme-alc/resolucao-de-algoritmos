using System.Runtime.InteropServices;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro = Guid.NewGuid().GetHashCode();
            Console.WriteLine(inteiro);
        }
    }
}

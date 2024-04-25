using System.Collections;

namespace Questao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public Stack CopiaStack (Stack origem) a qual retorna uma cópia da Stack origem passada como parâmetro. Os elementos da Stack origem devem permacer na mesma ordem original. Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Stack.
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);
            pilha.Push(6);
            Stack copiaPilha = CopiaStack(pilha);
            foreach(int item in pilha)
            {
                Console.WriteLine(item);
            }
        }
        public static Stack CopiaStack(Stack origem)
        {
            Stack temp = new Stack();
            Stack copiaTemp = new Stack();
            foreach(int item in origem)
            {
                temp.Push(item);
            }
            foreach(int item in temp)
            {
                copiaTemp.Push(item);
            }
            return copiaTemp;
        }
    }
}

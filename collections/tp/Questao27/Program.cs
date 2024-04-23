namespace Questao27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public Stack<T> CopiaStack<T>(Stack<T> origem) a qual retorna uma cópia da Stack<T> origem passada como parâmetro. Os elementos da Stack origem devem permacer na mesma ordem original.
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Stack<int> copiaStack = CopiaStack(stack);
        }
        public static Stack<int> CopiaStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> temp2 = new Stack<int>();
            foreach(int i in stack)
            {
                temp.Push(i);
            }
            foreach(int i in temp)
            {
                temp2.Push(i);
            }
            return temp2;
        }
    }
}

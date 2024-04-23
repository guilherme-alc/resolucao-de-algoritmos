namespace Questao28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie o procedimento public void VaiProFundo<T>(Stack<T> origem, T elemento) que empilha o elemento passado como parâmetro no fundo da Stack<T> origem, ao invés de empilhar no topo.
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            VaiProFundo(stack, 0);
        }
        public static void VaiProFundo(Stack<int> origem, int elemento) 
        {
            Stack<int> temp = new Stack<int>();
            foreach(int i in origem)
            {
                temp.Push(i);
            }
            temp.Push(elemento);
            origem.Clear();
            foreach(int i in temp)
            {
                origem.Push(i);
            }
        }
    }
}

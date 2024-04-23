namespace Questao29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie o procedimento public void InverteQueue<T>(Queue<T> Q) que inverte a ordem dos elementos do Queue<T> Q, no próprio Queue. OBS1: utilize outras estruturas que julgar necessárias. OBS2: nesse exercício você não deve utilizar o método reverse.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
        }
        public static void InverteQueue(Queue<int> Q)
        {
            Stack<int> tempStack = new Stack<int>();
            foreach(int i in Q)
            {
                tempStack.Push(i);
            }
            Q.Clear();
            foreach(int i in tempStack)
            {
                Q.Enqueue(i);
            }
        }
    }
}

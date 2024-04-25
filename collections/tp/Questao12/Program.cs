using System.Collections;
namespace Questao12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public Queue CopiaQueue(Queue origem) a qual retorna uma cópia da Queue origem passada como parâmetro. Os elementos da Queue origem devem permacer na mesma ordem original. Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Queue.
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(34);
            fila.Enqueue(5);
            fila.Enqueue(68);
            Queue filaCopia = CopiaQueue(fila);
        }
        public static Queue CopiaQueue(Queue origem) 
        { 
            Queue temp = new Queue();
            foreach (int elem in origem) {
                temp.Enqueue(elem);
            }
            return temp;
        }
    }
}

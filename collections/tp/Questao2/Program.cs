using System.Collections;
namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public ArrayList CopiaQueueParaArrayList(Queue origem), que copia todos os dados do Queue origem e retorna o novo ArrayList criado. Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
            Queue fila = new Queue();
            fila.Enqueue("João");
            fila.Enqueue("Pedro");
            fila.Enqueue("Maurício");
            fila.Enqueue("Estela");
            fila.Enqueue("William");
            fila.Enqueue("Verônica");
            ArrayList al = CopiaQueueParaArrayList(fila);
        }
        public static ArrayList CopiaQueueParaArrayList(Queue origem)
        {
            ArrayList temp = new ArrayList();
            for(int i = 0; i < origem.Count; i++)
            {
                temp.Add(origem.Dequeue());
            }
            return temp;
        }
    }
}

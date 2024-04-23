using System.Collections;
namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public ArrayList CopiaArrayList(ArrayList origem) que copia todos os dados do ArrayList origem e retorna o novo ArrayList criado. Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
            ArrayList al = new ArrayList() {1, 2, 12, 21, 10, 20};
            ArrayList novoAl = CopiaArrayList(al);
        }
        public static ArrayList CopiaArrayList(ArrayList origem)
        {
            ArrayList temp = new ArrayList();
            foreach(int elem in origem)
            {
                temp.Add(elem);
            }
            return temp;
        }
    }
}

using System.Collections;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Crie o procedimento public void ApagaArrayList2(ArrayList origem, int inicio, int qtde), o qual apaga todos os qtde elementos à partir da posição determinada pelo parâmetro início. Atenção: não é permitido usar o método RemoveRange(), apenas Remove() e RemoveAt().
            ArrayList al = new ArrayList() { 1, 2, 12, 21, 10, 20, 100, 200, 101, 201, 121, 212, 111, 222, 112, 221 };
            ApagaArrayList2(al, 3, 4);
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
        }
        public static void ApagaArrayList2(ArrayList origem, int inicio, int qtde)
        {
            for (int i = inicio; i < origem.Count; i++)
            {
                if (qtde > 0)
                {
                    origem.RemoveAt(i);
                    qtde--;
                    i--;
                }
            }
        }
    }
}

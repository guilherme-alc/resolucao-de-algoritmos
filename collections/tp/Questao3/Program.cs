using System.Collections;
namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public ArrayList CopiaParteArrayList (ArrayList origem, int inicio, int final), a qual retorna um ArrayList contendo todos os elementos dentro do intervalo determinado pelos parâmetros inicio e final. Não é permitido usar o método CopyTo() do ArrayList. Atenção: caso o ArrayList origem tenha menos posições do que a determinada pelo parâmetro final, copie até a sua última posição. Caso o parâmetro inicio seja maior que a quantidade de elementos do ArrayList origem, retorne um ArrayList vazio. Por fim, se o parâmetro inicio for maior que o parâmetro final, indica que o usuário deseja copiar os dados na ordem invertida.
            ArrayList al = new ArrayList() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            ArrayList newAl = CopiaParteArrayList(al, 10, 3);
        }
        public static ArrayList CopiaParteArrayList(ArrayList origem, int inicio, int final)
        {
            ArrayList temp = new ArrayList();
            if(origem.Count < final && origem.Count > inicio)
            {
                for(int i = inicio; i < origem.Count; i++)
                    temp.Add(origem[i]);

            } else if(inicio > origem.Count)
            {
                return temp;
            } else if (inicio > final)
            {
                for(int i = inicio - 1; i >= final; i--)
                {
                    temp.Add(origem[i]);
                }
            } else
            {
                for(int i = inicio; i <= final; i++)
                {
                    temp.Add(origem[i]);
                }
            }
            return temp;
        }
    }
}

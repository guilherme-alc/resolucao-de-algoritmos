using System.Collections;
using System;
namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie o procedimento public void ApagaArrayList(ArrayList origem, int inicio, int final), o qual apaga todos os elementos no intervalo determinado pelos parâmetros inicio e final. Atenção: não é permitido usar o método RemoveRange(). Apenas Remove() e RemoveAt().
            //Exemplo: ApagaArrayList(AL, 7, 10) => apagar os elementos entre as posições 7 e 10.
            ArrayList al = new ArrayList() {1, 2, 12, 21, 10, 20, 100, 200, 101, 201, 121, 212, 111, 222, 112, 221};
            ApagaArrayList(al, 0, 5);
        }
        public static void ApagaArrayList(ArrayList origem, int inicio, int final) 
        {
            for(int i = inicio; i <= final; i++)
            {
                origem.RemoveAt(i);
                i--;
                final--;
            }
            //Obs: Levei em consideração que era pra apagar o início e o final também
        }
    }
}

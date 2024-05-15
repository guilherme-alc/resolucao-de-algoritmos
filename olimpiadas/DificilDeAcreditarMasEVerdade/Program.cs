namespace DificilDeAcreditarMasEVerdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            do
            {
                entrada = Console.ReadLine();
                char [] operacaoInverso = new char[entrada.Length];
                for(int i = entrada.Length-1, j = 0; i >= 0; i--)
                {
                    operacaoInverso[j] = entrada[i];
                    j++;
                }
                string operacao = new string (operacaoInverso);
                string [] primeiraDivisao = operacao.Split('=');
                string resultado = primeiraDivisao[0];
                string[] numsCalculados = primeiraDivisao[1].Split('+');
                string num1 = numsCalculados[1];
                string num2 = numsCalculados[0];
                if(resultado.Length <= 7 && num1.Length <= 7 && num2.Length <= 7)
                {
                    int resul = int.Parse(primeiraDivisao[0]);
                    int n1 = int.Parse(numsCalculados[1]);
                    int n2 = int.Parse(numsCalculados[0]);
                    if(n1 + n2 == resul)
                    {
                        Console.WriteLine("True");
                    } else
                    {
                        Console.WriteLine("False");
                    }
                }
            } while (entrada != "0+0=0");
        }
    }
}

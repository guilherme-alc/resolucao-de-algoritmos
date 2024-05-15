namespace Adivinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QtdCamisetas = int.Parse(Console.ReadLine());
            for(int i = 0; i < QtdCamisetas; i++)
            {
                string [] entrada = Console.ReadLine().Split(' ');
                int qtdAlunosGrupo = int.Parse(entrada[0]);
                int numSecreto = int.Parse(entrada[1]);

                if((qtdAlunosGrupo >= 4 && qtdAlunosGrupo <= 10) && (numSecreto >= 1 && numSecreto <= 100))
                {
                    string [] segundaEntrada = Console.ReadLine().Split(' ');
                    int posicao = 0;
                    bool achou = false;
                    int [] chuteDosAlunos = new int[qtdAlunosGrupo];
                    for(int j = 0; j < qtdAlunosGrupo; j++)
                    {
                        chuteDosAlunos[j] = int.Parse(segundaEntrada[j]);
                    }
                    for(int y = 0; y < qtdAlunosGrupo; y++)
                    {
                        if(numSecreto == chuteDosAlunos[y] && achou == false)
                        {
                            posicao = y + 1;
                            achou = true;
                        } else
                        {
                            if(numSecreto >= chuteDosAlunos[y])
                            {
                                chuteDosAlunos[y] = numSecreto - chuteDosAlunos[y];
                            } else
                            {
                                chuteDosAlunos[y] = chuteDosAlunos[y] - numSecreto;
                            }
                        }
                    }
                    if(achou != true)
                    {
                        int maisProximo = int.MaxValue;
                        bool achouMaisProximo = false;

                        for (int x = 0; x < qtdAlunosGrupo; x++)
                        {
                            int numAtual = chuteDosAlunos[x];
                            if(numAtual == maisProximo && achouMaisProximo == true)
                            {
                                posicao += 0;
                            } else if (chuteDosAlunos[x] <= maisProximo)
                            {
                                maisProximo = chuteDosAlunos[x];
                                posicao = x + 1;
                                achouMaisProximo = true;
                            }
                        }
                    }
                    Console.WriteLine(posicao);
                }
            }
        }
    }
}

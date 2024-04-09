namespace AceleradorDeParticulasV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdExperimento = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtdExperimento; i++)
            {
                int distancia = int.Parse(Console.ReadLine());
                //o resto da divisão da (distância - 5 por 8), define o sensor de saída
                //3 é a distância do emissor até o acelerador e 2 é a distância do acelerador até a saída 3 + 2 = 5, 8 é a circunferência do acelerador 
                Console.WriteLine((distancia - 5) % 8);
            }
        }
    }
}

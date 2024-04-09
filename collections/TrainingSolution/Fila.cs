namespace TrainingSolution
{
    internal class Fila
    {
        public static void Executar()
        {
            Console.WriteLine("Insira o valor do primeiro intervalo");
            int intervaloX = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo intervalo");
            int intervaloY = int.Parse(Console.ReadLine());
            if(intervaloX - intervaloY > 0) 
            {
                Console.WriteLine("Intervalo inválido, o primeiro número inserido é maior do que o segundo");
                return;
            }

            Queue<int> fila = new Queue<int>();
            for(int i = intervaloX; i <= intervaloY; i++)
            {
                if(i%2 != 0)
                {
                    fila.Enqueue(i);
                }
            }
            Console.Clear();

            Console.WriteLine("Imprimindo com for:");
            int[] arrayDePrimos = fila.ToArray();
            for(int i = 0 ; i < arrayDePrimos.Length; i++)
            {
                Console.Write(arrayDePrimos[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo com foreach:");
            foreach(int impar in fila)
            {
                Console.Write(impar + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nImprimindo na ordem inversa com foreach:");
            List<int> filaInvertida = fila.ToList();
            filaInvertida.Reverse();
            foreach (int impar in filaInvertida)
            {
                Console.Write(impar + " ");
            }
            Console.WriteLine();

        }
    }
}

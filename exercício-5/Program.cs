using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            ImprimirMatriz(matriz);
            InverterElementosDiagonal(matriz);
            ImprimirMatriz(matriz);
        }

        public static void ImprimirMatriz(int[,] matriz)
        {
            var tamanhoMatriz = matriz.GetLength(0);
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("___");
        }

        public static void InverterElementosDiagonal(int[,] matriz)
        {
            int tamanhoMatriz = matriz.GetLength(0);
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                int temp = matriz[i, i];
                matriz[i, i] = matriz[i, tamanhoMatriz - i - 1];
                matriz[i, tamanhoMatriz - i - 1] = temp;
            }
        }
    }
}

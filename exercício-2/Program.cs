using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = Ordenar(new int[] { 5, 1, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 5 });
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        public static int[] Ordenar(int[] numeros)
        {
            for (int i = 1; i < numeros.Length; i++)
            {
                int atual = numeros[i];
                int j = i - 1;

                while (j >= 0 && numeros[j] > atual)
                {
                    numeros[j + 1] = numeros[j];
                    j--;
                }

                numeros[j + 1] = atual;
            }

            return numeros;
        }
    }
}

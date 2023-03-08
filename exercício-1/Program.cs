using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Moda(new int[] { 5, 1, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 5 }));
        }

        public static int Moda(int[] numeros)
        {
            var contador = new Dictionary<int, int>();
            for (int i = 0; i < numeros.Length; i++)
            {
                if (contador.ContainsKey(numeros[i]))
                {
                    contador[numeros[i]] += 1;
                }
                else
                {
                    contador[numeros[i]] = 1;
                }
            }

            var quantidadeRepeticao = 0;
            var moda = 0;
            for (int i = 0; i < contador.Count; i++)
            {
                var par = contador.ElementAt(i);
                if (par.Value > quantidadeRepeticao)
                {
                    quantidadeRepeticao = par.Value;
                    moda = par.Key;
                }
            }

            return moda;
        }
    }
}

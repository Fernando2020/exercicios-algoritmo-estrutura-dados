using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PossibilidadesSoma(10);
        }

        static void PossibilidadesSoma(int n)
        {
            int[] numeros = new int[n];
            PossibilidadesSomaRec(numeros, n, 0);
        }

        static void ImprimirLista(int[] numeros, int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
        }

        static void PossibilidadesSomaRec(int[] numeros, int entrada, int indice)
        {
            if (entrada == 0)
            {
                ImprimirLista(numeros, indice);
            }
            else
            {
                var numero = entrada;
                if (indice > 0)
                {
                    numero = numero < numeros[indice - 1] ? numero : numeros[indice - 1];
                }

                for (int i = 1; i <= numero; i++)
                {
                    numeros[indice] = i;
                    PossibilidadesSomaRec(numeros, entrada - i, indice + 1);
                }
            }
        }
    }
}

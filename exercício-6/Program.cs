using System;
using System.IO;


namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaMatriz("A.txt", 200, 350);
            CriaMatriz("B.txt", 3, 4);


            int[,] A = LerMatriz("A.txt");
            int[,] B = LerMatriz("B.txt");


            Console.WriteLine(NumeroDeOcorrencias(A, B));
        }


        static int NumeroDeOcorrencias(int[,] matriz, int[,] padrao)
        {
            int N = matriz.GetLength(0), M = matriz.GetLength(1);
            int n = padrao.GetLength(0), m = padrao.GetLength(1);
            int contador = 0;

            for (int i = 0; i <= N - n; i++)
            {
                for (int j = 0; j <= M - m; j++)
                {
                    bool pertence = true;

                    for (int a = 0; a < n; a++)
                    {
                        for (int b = 0; b < m; b++)
                        {
                            if (matriz[i + a, j + b] != padrao[a, b])
                            {
                                pertence = false;
                                break;
                            }
                        }
                        if (!pertence)
                        {
                            break;
                        }
                    }
                    if (pertence)
                    {
                        contador++;
                    }
                }
            }

            return contador;
        }


        static int[,] LerMatriz(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string[] tamanho = sr.ReadLine().Split(' ');
            int n = int.Parse(tamanho[0]);
            int m = int.Parse(tamanho[1]);
            int[,] ret = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                string linha = sr.ReadLine();
                for (int j = 0; j < m; ++j)
                    ret[i, j] = linha[j] == '0' ? 0 : 1;
            }
            sr.Close();
            return ret;
        }


        static void CriaMatriz(string fileName, int n, int m)
        {
            Random r = new Random();
            FileStream f = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            sw.Write($"{n} {m}\r\n");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    sw.Write(r.Next(2) == 0 ? '0' : '1');
                sw.Write("\r\n");
            }
            sw.Close();
            f.Close();
        }
    }
}

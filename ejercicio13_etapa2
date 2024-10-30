using System;

namespace rotacion_de_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando un for y un vector se debe obtener la diagonal principal de una Matriz nxn con
            //datos aleatorios.
            Random random = new Random();
            int n = 4;
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[] diagonalPrincipal = new int[n];
            for (int i = 0; i < n; i++)
            {
                diagonalPrincipal[i] = matriz[i, i];
            }

           Console.WriteLine("\nDiagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonalPrincipal[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}

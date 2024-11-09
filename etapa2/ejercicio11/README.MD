using System;

namespace rotacion_de_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz_cuadrada = new int[3, 3];
            for (int filas = 0; filas < matriz_cuadrada.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_cuadrada.GetLength(1); columnas++)
                {
                    Console.Write("Ingrese valor para matriz cuadrada[{0},{1}]: ", filas, columnas);
                    matriz_cuadrada[filas, columnas] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz original:");
            for (int filas = 0; filas < matriz_cuadrada.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_cuadrada.GetLength(1); columnas++)
                {
                    Console.Write(matriz_cuadrada[filas, columnas] + " ");
                }
                Console.WriteLine();
            }

            int[,] matriz_rotada = new int[3, 3];
            int n = matriz_cuadrada.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_rotada[j, n - 1 - i] = matriz_cuadrada[i, j];
                }
            }

            Console.WriteLine("\nMatriz rotada 90 grados en sentido horario:");
            for (int filas = 0; filas < matriz_rotada.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_rotada.GetLength(1); columnas++)
                {
                    Console.Write(matriz_rotada[filas, columnas] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

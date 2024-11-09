using System;

namespace suma_de_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sumar dos matrices de igual tamaño nxn.
            int[,] matriz_A = new int[2, 2];
            Console.WriteLine("ingrese los valores de la matriz A: ");
            for (int filas = 0; filas < matriz_A.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_A.GetLength(1); columnas++)
                {
                    matriz_A[filas, columnas] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Matriz A");
            for (int filas = 0; filas < matriz_A.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_A.GetLength(1); columnas++)
                {
                    Console.WriteLine("" + matriz_A[filas, columnas]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            int[,] matriz_B = new int[2, 2];
            Console.WriteLine("ingrese los valores de la matriz B: ");
            for (int filas = 0; filas < matriz_B.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_B.GetLength(1); columnas++)
                {
                    matriz_B[filas, columnas] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Matriz B");
            for (int filas = 0; filas < matriz_B.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_B.GetLength(0); columnas++)
                {
                    Console.WriteLine("" + matriz_B[filas, columnas]);
                }
                Console.WriteLine();
            }
            int[,] matriz_C = new int[2, 2];
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("La suma de las dos matrices: ");
            for (int filas = 0; filas < matriz_C.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz_C.GetLength(1); columnas++)
                {
                    matriz_C[filas, columnas] = matriz_A[filas, columnas] + matriz_B[filas, columnas];
                    Console.WriteLine(matriz_C[filas, columnas]);
                }
            }
            
        }
    }
}

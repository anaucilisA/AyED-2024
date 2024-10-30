using System;

namespace valores_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llenar una matriz de n×m con valores aleatorios entre un rango dado
            //(por ejemplo, 1 a 100).
            int n, m;
            Console.WriteLine("ingrese valor: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro valor: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            for (int filas = 0; filas < matriz.GetLength(0);filas++)
            {
                for (int columnas = 0; columnas < matriz.GetLength(1); columnas++)
                {
                    Random aleatorio = new Random();
                    matriz[filas, columnas] = aleatorio.Next(0, 10);
                }
            }
            Console.Clear();
            for (int filas = 0; filas < matriz.GetLength(0);filas++)
            {
                for (int columnas = 0; columnas < matriz.GetLength(1); columnas++)
                {
                    Console.WriteLine("" + matriz[filas, columnas]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

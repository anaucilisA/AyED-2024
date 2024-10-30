using System;
using System.Runtime.ConstrainedExecution;

namespace mi_MatrizA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n×m con todos sus elementos inicializados a cero. Imprimirla por pantalla n y m
            //son datos que ingresa el usuario.
            Console.WriteLine("valor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("valor: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,m];
            int recorrer = 0; 
            for(int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    matriz[fila, columna] = 0;
                }
            }
            Console.Clear();
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine("" + matriz[fila, columna]);
                }
                Console.WriteLine();
            }
        }   
    }
}

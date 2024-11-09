using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("cuantas vueltas dio el RayoMcQueen?:");
        int vueltas = int.Parse(Console.ReadLine());
        int[] cant_vueltas = new int[vueltas];
        int tiempo = 0;
        for (int i = 0; i < vueltas; i++)
        {
            Console.WriteLine("cuanto tardo (segundos) en la vuelta num. " + (i + 1) + "?: ");
            int segundos = int.Parse(Console.ReadLine());
            cant_vueltas[i] = segundos;
            tiempo += segundos;
        }
        Console.WriteLine("tiempo total: " + tiempo);
        Console.WriteLine("promedio de tiempo por vuelta: " + tiempo/vueltas);
        int mejor_vuelta = cant_vueltas[0];
        for (int i = 0; i < vueltas; i++)
            if (cant_vueltas[i] > mejor_vuelta)
            {
                mejor_vuelta = cant_vueltas[i];
            }
        Console.WriteLine("la mejor vuelta: " + mejor_vuelta);
        Console.ReadKey();
    }
}

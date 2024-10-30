using System;

namespace estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz Nx3 donde cada fila representa un estudiante y cada columna contiene
            //información como el nombre, la edad y la calificación.
            int n = 3; // Número de estudiantes
            object[,] estudiantes = new object[n, 3];

            // Llenar la matriz con datos de estudiantes
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese el nombre del estudiante {0}: ", i + 1);
                estudiantes[i, 0] = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante {0}: ", i + 1);
                estudiantes[i, 1] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la calificación del estudiante {0}: ", i + 1);
                estudiantes[i, 2] = double.Parse(Console.ReadLine());
            }

            // Imprimir la matriz
            Console.WriteLine("\nMatriz de Estudiantes:");
            Console.WriteLine("Nombre\tEdad\tCalificación");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", estudiantes[i, 0], estudiantes[i, 1], estudiantes[i, 2]);
            }

            Console.ReadKey();
        }
    }
}

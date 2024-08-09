namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar el tamaño del vector");
            int tamaño = int.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];
            Random aleatorio = new Random();
            for (int i = 0; i < tamaño; i++)
            {

                vector[i] = aleatorio.Next(0, 100);
            }
            Console.WriteLine("MENÚ");
            Console.WriteLine("1-imprime en pantalla todos los elementos del vector");
            Console.WriteLine("2-El usuario ingresa un número y el programa busca si este se encuentra en el vector. " +
                "Si lo encuentra, se indica la posición en la que se encuentra.");
            Console.WriteLine("3-Se ordena el vector de forma ascendente o descendente, según la elección del usuario.");
            Console.WriteLine("4- Termina la ejecución del programa.");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("_________________________________________");
                    for (int i = 0; i < tamaño; i++)
                    {
                        Console.WriteLine(vector[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("ingrese un numero: ");
                    int num = int.Parse(Console.ReadLine());
                    bool encontrado = false;
                    for (int i = 0; i < tamaño; i++)
                    {
                        if (vector[i] == num)
                        {
                            Console.WriteLine(num);
                        }
                        else
                        {
                            Console.WriteLine("no se encuentra en el vector este numero :(");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("elija un tipo de orden: 1- ascendente  2- descendente");
                    int tipo = int.Parse(Console.ReadLine());
                    if (tipo == 1)
                    {
                        Array.Sort(vector);
                    }
                    else if (tipo == 2)
                    {
                        Array.Reverse(vector);
                    }
                    break;
                default:
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("eligió salir del programa");
                    break;
            }
            Console.ReadKey();
        }
    }
}

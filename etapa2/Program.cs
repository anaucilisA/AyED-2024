int c_invitados;
bool bucle = true;
int cantidad;
Console.Write("ingresa la cantidad de invitados ");
c_invitados = int.Parse(Console.ReadLine());
int[] invitados = new int[c_invitados];
int c_comida = 0;
for (int i = 1; i < c_invitados; i++)
{
    while (bucle)
    {
        Console.WriteLine("cuanta comida consume el invitado " + (i + 1) + "?");
        cantidad = int.Parse(Console.ReadLine());
        if (cantidad < 1 & cantidad > 100)
        {
            bucle = true;
            Console.WriteLine("por favor entre 1 y 100");
        }
        else if (cantidad > 1 & cantidad < 100)
        {
            bucle = false;
            invitados[i] = cantidad;
        }

    }
    bucle = true;
    c_comida = c_comida + invitados[i];
}
Console.WriteLine("el promedio es " + (c_comida / c_invitados));
Console.ReadKey();
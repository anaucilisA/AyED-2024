Console.WriteLine("ingrese la cantidad de jugadores");
int jugadores = int.Parse(Console.ReadLine());
int[] losJugadores = new int[jugadores];
bool bucle = true;
int orden = 0;
for (int i = 0; i < jugadores; i++)
{
    Console.Clear();
    Console.WriteLine("ingrese el punto del jugador " + (i + 1));
    int puntos = int.Parse(Console.ReadLine());
    losJugadores[i] = puntos;
}
for (int i = 0; i < jugadores - 1; i++)

{
    for (int t = 0; t < jugadores - 1; t++)
    {
        if (losJugadores[t] < losJugadores[t + 1])
        {
            orden = losJugadores[t + 1];
            losJugadores[t + 1] = losJugadores[t];
            losJugadores[t] = orden;
        }
    }
}
Console.Clear();
Console.WriteLine("aqui los puntajes de menor a mayor: ");
for (int i = 0; i < jugadores; i++)
{
    Console.WriteLine(losJugadores[i]);
    Console.WriteLine("-------------------------");
}
Console.ReadKey();


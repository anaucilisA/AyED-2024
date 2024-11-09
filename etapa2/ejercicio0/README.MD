Console.WriteLine("ingresa la cantidad de obstaculos: ");
int obstaculos;
obstaculos = int.Parse(Console.ReadLine());
int[] puntaje = new int[obstaculos];
int puntaje_t;
string respuesta;
for (int i = 0; i < obstaculos; i++)
{
    Console.WriteLine("obstaculo " + (i + 1) + " lo supera?: ");
    respuesta = Console.ReadLine();
    if (respuesta == "si")
    {
        puntaje[i] = 10;
    }
    else if (respuesta == "no")
    {
        puntaje[i] = -5;
    }

}
puntaje_t = 0;

for (int i = 0; i < obstaculos; i++)
{
    puntaje_t += puntaje[i];
}
Console.WriteLine("puntaje total = " + puntaje_t);
Console.ReadKey();

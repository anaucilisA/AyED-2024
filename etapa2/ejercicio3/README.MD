int Totalp = 0;
int puedenAprobar = 0;
int porcentaje = 0;
Console.WriteLine("ingrese la cantidad de pruebas");
int pruebas = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa la cantidad de tps");
int tp = int.Parse(Console.ReadLine());
int[] lasPruebas = new int[pruebas];
int[] losTps = new int[tp];
for (int i = 0; i < pruebas; i++)
{
    Console.WriteLine("ingresa la nota que saco en la prueba " + (i + 1));
    int nota = int.Parse(Console.ReadLine());
    lasPruebas[i] = nota;
}
for (int i = 0; i < pruebas; i++)
{
    Totalp = Totalp + lasPruebas[i];
}
for (int i = 0; i < tp; i++)
{
    Console.WriteLine("ingresa la nota que saco en el tp " + (i + 1));
    int nota = int.Parse(Console.ReadLine());
    losTps[i] = nota;
    if (losTps[i] >= 6)
    {
        porcentaje++;
    }
}
puedenAprobar = (int)(0.75 * tp);
if ((Totalp) >= 6 && porcentaje >= (puedenAprobar))
{
    Console.WriteLine("Aprobaron");
}
else
{
    Console.WriteLine("no pueden aprobar");
}
Console.ReadKey();

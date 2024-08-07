//El programa solicitará al usuario que ingrese la cantidad de candidatos que realizaron el examen.Luego, pedirá al usuario
//que ingrese los puntajes de cada candidato, uno por uno.Una vez ingresados todos los puntajes, el programa los ordenará
//de menor a mayor.Posteriormente, el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes
//múltiplos de ese número.Finalmente, mostrará al usuario la lista de puntajes ordenados y los puntajes que son múltiplos
//del número especificado.
int candidatos;
int orden = 0;
int entero;
Console.Write("ingrese la cantidad de candidatos: ");
candidatos = int.Parse(Console.ReadLine());
int[] losCandidatos = new int[candidatos];
Console.WriteLine("-------------------------------------");
for (int i = 0; i < candidatos; i++)
{
    Console.WriteLine("ingresa el puntaje del candidato " + (i + 1));
    int puntaje = int.Parse(Console.ReadLine());
    losCandidatos[i] = puntaje;
}
for (int i = 0; i < candidatos - 1; i++)

{
    for (int t = 0; t < candidatos - 1; t++)
    {
        if (losCandidatos[t] > losCandidatos[t + 1])
        {
            orden = losCandidatos[t + 1];
            losCandidatos[t + 1] = losCandidatos[t];
            losCandidatos[t] = orden;
        }
    }
}
Console.WriteLine("-----------------------------------------"); 
Console.WriteLine("lista con los puntajes ordenados ");
for (int i = 0; i < candidatos; i++) 
{
    Console.WriteLine(losCandidatos[i]);
}
    Console.WriteLine("---------------------------------------");
    Console.Write("ingrese un numero entero = ");
    entero = int.Parse(Console.ReadLine());
    Console.WriteLine("---------------------------------------"); 
    Console.WriteLine("Puntajes que son multiplos del num entero: "); 
for (int i = 0; i < candidatos; i++)
{ 
    if (losCandidatos[i] % entero == 0)
    { 
        Console.WriteLine(losCandidatos[i]);
    } 
}
Console.ReadKey();

// See https://aka.ms/new-console-template for more information
//El programa solicitará al usuario que ingrese la cantidad de elementos (objetos) que desea analizar.Luego, pedirá al usuario que ingrese el valor mínimo
//que deben tener los objetos para ser considerados en el filtro.Seguidamente, el programa solicitará al usuario que ingrese los valores de los objetos,
//uno por uno.Una vez ingresados todos los valores, el programa mostrará al usuario las posiciones en las que se encuentran los objetos cuyo valor es mayor
//al número especificado.
int valor_minimo = 0;
int elementos = 0;
Console.WriteLine("ingrese la cantidad de elementos: ");
elementos = int.Parse(Console.ReadLine());
int[] valor = new int[elementos];
Console.WriteLine("ingrese el valor minimo para los elementos: ");
valor_minimo = int.Parse(Console.ReadLine());
for (int i = 0; i < elementos; i++)
{
    Console.WriteLine("cual es el valor del elemento " + (i + 1) + "?");
    int v_elemento = int.Parse(Console.ReadLine());
    valor[i] = v_elemento;
}
Console.WriteLine("elementos que tienen el valor mayor que el valor minimo: ");
for (int j = 0; j < elementos; j++)
{
    if (valor_minimo < valor[j])
    {
        Console.WriteLine("elemento " + (j + 1) + " con valor: " + valor[j]);
    }
}
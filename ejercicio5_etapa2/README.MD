int precios = 0;
int t = 0;
Console.WriteLine("cuantos productos se vendieron en el Hot Sale?: ");
int productos_vendidos = int.Parse(Console.ReadLine());
int[] productos = new int[productos_vendidos];
for (int i = 0; i < productos_vendidos; i++)
{
    Console.WriteLine("cual es el precio del producto " + (i + 1) + "?");
    precios = int.Parse(Console.ReadLine());
    productos[i] = precios;
}
int precio_mas_alto = productos[0];
int precios_mas_bajos = productos[0];
for (int i = 0; i < productos_vendidos; i++)
{
    
    if (productos[i] > precio_mas_alto)
        {
        precio_mas_alto = productos[i];
        }
    if (productos[i] < precios_mas_bajos)
    {
        precios_mas_bajos = productos[i];
    }
}
Console.WriteLine("el precio más alto es: "+ precio_mas_alto);
Console.WriteLine("el precio más bajo es: " + precios_mas_bajos);
Console.ReadKey();

//Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit.
//Solicite al usuario la cantidad de grados centígrados para convertirlos usando las
//siguientes tablas de conversión:
//kelvin = celsius + 273
//fahrenheit = celsius x 18/10 + 32
Console.WriteLine("cantidad de grados centigrados: ");
int cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("kelvin: " + (cantidad + 273));
Console.WriteLine("farenheit: " + (cantidad * 18/10 + 32));
Console.ReadKey();

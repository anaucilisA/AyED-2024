//Escribe un programa en C# que calcule el resultado de sumar, restar, multiplicar y dividir
//dos números introducidos por el usuario.
//Además también debería calcular el resto de la división en la última linea.
Console.WriteLine("ingrese un numero por favor: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese otro numero por favor: ");
int num_2 = int.Parse(Console.ReadLine());
Console.WriteLine("suma: " + (num_1 + num_2));
Console.WriteLine("resta: " + (num_1 - num_2));
Console.WriteLine("multiplicacion: " + num_1 * num_2);
Console.WriteLine("division: " + num_1 / num_2);
Console.WriteLine("resto de la division: " + num_1 % num_2);
Console.ReadKey();

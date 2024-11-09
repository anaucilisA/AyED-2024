//Escribir un programa que pida al usuario una palabra
            //y la muestre por pantalla 10 veces.
            string palabra;
            int contador;
            Console.WriteLine("escriba una palabra: ");
            palabra = Console.ReadLine();
            contador = 0;
            while (contador < 9)
            {
                Console.WriteLine(palabra);
                contador++;
            }
            Console.ReadKey();

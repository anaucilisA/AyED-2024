            Console.WriteLine("su edad por favor: ");
            edad = int.Parse(Console.ReadLine());
            contador = 0;
            while (contador < 16)
            {
                Console.WriteLine(edad);
                edad++;
                contador++;
            }
            Console.ReadKey();

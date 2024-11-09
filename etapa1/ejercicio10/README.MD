int num_uno, num_dos;
            Console.WriteLine("ingrese un numero por favor: ");
            num_uno = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro: ");
            num_dos = int.Parse(Console.ReadLine());
            if (num_dos == 0)
            {
                Console.WriteLine("no se puede hacer la division");
            }
            else
            {
                Console.WriteLine("el resultado de la division es: "+ num_uno / num_dos);
            }
            Console.ReadKey();

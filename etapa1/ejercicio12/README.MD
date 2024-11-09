int edad, ingresos;
            Console.WriteLine("su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("sus ingresos: ");
            ingresos = int.Parse(Console.ReadLine());
            if(edad > 19)
            {
                Console.WriteLine("sus ingresos mensuales: ");
            }
            else
            {
                Console.WriteLine("no puede cobrar la beca");
            }
            Console.ReadKey();

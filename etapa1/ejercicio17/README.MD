string salir;
            bool opcion = true;
            while (opcion)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                salir = Console.ReadLine();
                if(salir == "1")
                {
                    Console.Write("bienvenido al programa ");
                }
                else if(salir == "2")
                {
                    Console.WriteLine("2+2 = 4");
                }
                else if (salir == "3")
                {
                    Console.WriteLine("pi = 3,14");
                }
                else if (salir == "4")
                {
                    Console.WriteLine("saliste del menu");
                    opcion = false;
                    Console.Clear();
                }

bool buc = true;
            string respuesta;
            String si = "SI";

            while (buc)
            {
                Console.WriteLine("Diga SI para terminar");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Desea termianr el programa?");
                respuesta = Console.ReadLine();
                if (respuesta == si)
                {
                    Console.WriteLine("PRECIONE CUALQUIER TECLA");
                    buc = false;
                }
            }
            Console.ReadKey();


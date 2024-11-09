int contador;
            contador = 1;
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
                if (contador % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if(contador % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if((contador % 3 == 0) && (contador % 5 == 0))
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();

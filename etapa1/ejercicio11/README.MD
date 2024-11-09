int num;
            Console.WriteLine("un numero por favor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("el numero es impar");
            }
            else
            {
                Console.WriteLine("el numero es par");
            }
            Console.ReadKey();

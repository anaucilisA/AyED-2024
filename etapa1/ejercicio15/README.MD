int num_pos;
            Console.WriteLine("ingrese un número entero positivo: ");
            num_pos = int.Parse(Console.ReadLine());
            while (num_pos > 0)
            {
                Console.WriteLine(num_pos);
                num_pos--;
            }
            Console.ReadKey();

int radio;
            Console.WriteLine("ingrese un radio: ");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("la superficie de la esfera es: " + 4 * 3.14 * radio * radio);
            Console.WriteLine("el volumen de la esfera es: " + (4/3) * 3.14 * (radio * radio * radio));
            Console.ReadKey();

int edad;
            Console.WriteLine("ingrese su edad por favor: ");
            edad = int.Parse(Console.ReadLine());
            if(edad >= 18){
                Console.WriteLine("eres mayor de edad");
            }
            else
            {
                Console.WriteLine("eres menor de edad");
            }
            Console.ReadKey();

nt ancho, altura;
            Console.WriteLine("dame un valor de altura: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("dame un valor de ancho: ");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("el perimetro del rectangulo con estos valores es: "+ ((altura * altura) + (ancho * ancho)));
            Console.WriteLine("el area del rectangulo es: " + (ancho * altura));
            Console.WriteLine("la diagonal del rectangulo es: "+ (Math.Sqrt(ancho * ancho + altura * altura)));
            Console.ReadKey();

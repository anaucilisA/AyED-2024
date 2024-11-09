  // Recorre los números del 1 al N. (N lo tiene que ingresar
            //el usuario).
            //Muestra solamente los números pares.
            int num;
            int contador;
            contador = 1;
            Console.WriteLine("ingrese un numero: ");
            Console.WriteLine("-------------------");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("aqui estan los numeros pares hasta ese numero: ");
            while (contador <= num)
            {
                if(contador % 2 == 0)
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadKey();

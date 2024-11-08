using System.Collections.Generic;

namespace _4___ABM_DibuAventuras
{
    using System;

   
        // Definición de la clase Personaje
        class Personaje
        {
            public string Nombre;
            public string Serie;
            public int Fuerza;
            public int Defensa;
            public bool Heroe;

            public Personaje(string nombre, string serie, int fuerza, int defensa, bool heroe)
            {
                Nombre = nombre;
                Serie = serie;
                Fuerza = fuerza;
                Defensa = defensa;
                Heroe = heroe;
            }

            public override string ToString()
            {
                return $"Nombre: {Nombre}, Serie: {Serie}, Fuerza: {Fuerza}, Defensa: {Defensa}, Héroe: {(Heroe ? "Sí" : "No")}";
            }
        }

        class Program
        {
            static Personaje[] personajes = new Personaje[20];
            static int contadorPersonajes = 0; // Contador para llevar el registro de personajes añadidos

            static void Main(string[] args)
            {
                int opcion;

                do
                {
                    Console.WriteLine("\nBienvenidos a Dibuaventuras Multiversales");
                    Console.WriteLine("1. Agregar nuevo personaje");
                    Console.WriteLine("2. Consultar personaje por nombre");
                    Console.WriteLine("3. Modificar personaje");
                    Console.WriteLine("4. Eliminar personaje");
                    Console.WriteLine("5. Mostrar todos los personajes");
                    Console.WriteLine("6. Salir");
                    Console.Write("Selecciona una opción: ");

                    // Aseguramos que la opción ingresada sea válida
                    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
                    {
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción entre 1 y 6.");
                    }

                    switch (opcion)
                    {
                        case 1:
                            AgregarPersonaje();
                       
                            break;
                        case 2:
                            ConsultarPersonaje();
                        
                        break;
                       
                    case 3:
                            ModificarPersonaje();
                        Console.Clear();
                        break;
                        case 4:
                            EliminarPersonaje();
                        Console.Clear();
                        break;
                        case 5:
                            MostrarPersonajes();
                        
                        break;
                        case 6:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                    }

                } while (opcion != 6);
            }

            static void AgregarPersonaje()
            {
                if (contadorPersonajes >= 20)
                {
                    Console.WriteLine("La lista de personajes está llena. No puedes agregar más personajes.");
                    return;
                }

                Console.Write("Nombre del personaje: ");
                string nombre = Console.ReadLine();

                // Comprobamos si ya existe un personaje con el mismo nombre
                for (int i = 0; i < contadorPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        Console.WriteLine("Ya existe un personaje con ese nombre.");
                        return;
                    }
                }

                Console.Write("Serie: ");
                string serie = Console.ReadLine();
                Console.Write("Fuerza (número entero): ");
                int fuerza = int.Parse(Console.ReadLine());
                Console.Write("Defensa (número entero): ");
                int defensa = int.Parse(Console.ReadLine());
                Console.Write("¿Es héroe? (Sí/No): ");
                bool heroe = Console.ReadLine().ToLower() == "sí";

                personajes[contadorPersonajes] = new Personaje(nombre, serie, fuerza, defensa, heroe);
                contadorPersonajes++; // Incrementamos el contador
                Console.WriteLine("Personaje agregado ;)");
            }

            static void ConsultarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje a consultar: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < contadorPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        Console.WriteLine(personajes[i]);
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void ModificarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje a modificar: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < contadorPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        Console.WriteLine("Modificando personaje...");
                        Console.Write("Nueva Fuerza (número entero): ");
                        personajes[i].Fuerza = int.Parse(Console.ReadLine());
                        Console.Write("Nueva Defensa (número entero): ");
                        personajes[i].Defensa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Personaje modificado :)");
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void EliminarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje a eliminar: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < contadorPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        // Para eliminar el personaje, movemos los elementos hacia adelante
                        for (int j = i; j < contadorPersonajes - 1; j++)
                        {
                            personajes[j] = personajes[j + 1];
                        }
                        contadorPersonajes--; // Decrementamos el contador
                        Console.WriteLine("Personaje eliminado exitosamente.");
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void MostrarPersonajes()
            {
                // Verificar si no hay personajes en la lista
                if (contadorPersonajes == 0)
                {
                    Console.WriteLine("No hay personajes en la lista.");
                    return;
                }

                // Ordenar manualmente los personajes por nombre
                for (int i = 0; i < contadorPersonajes - 1; i++)
                {
                    for (int j = 0; j < contadorPersonajes - 1 - i; j++)
                    {
                        if (String.Compare(personajes[j].Nombre, personajes[j + 1].Nombre, true) > 0)
                        {
                            // Intercambiar los personajes si están en el orden incorrecto
                            Personaje temp = personajes[j];
                            personajes[j] = personajes[j + 1];
                            personajes[j + 1] = temp;
                        }
                    }
                }

                // Mostrar la lista de personajes
                Console.WriteLine("\nLista de personajes:");
                for (int i = 0; i < contadorPersonajes; i++)
                {
                    Console.WriteLine(personajes[i]);
                }
            }
        }
    }


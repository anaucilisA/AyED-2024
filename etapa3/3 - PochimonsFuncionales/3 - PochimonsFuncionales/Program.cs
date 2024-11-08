using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace _3___PochimonsFuncionales
{
    using System;
    
        class Program
        {
            static string nom, tipo; // Variables de nivel de clase
            static int nivel, opc = 0, val = 0, numinv = 0, elecp, aux;
            static string[,] matriz = new string[76, 6]; // Matriz para almacenar los Pochimons
            static Random rng = new Random(); // Generador de números aleatorios
            static bool par = true; // Control de bucle
            static string[] vector = new string[6]; // Encabezados de la matriz

            static void Main(string[] args)
            {
                vector[0] = "FILA";
                vector[1] = "NOMBRE";
                vector[2] = "TIPO";
                vector[3] = "NIVEL";
                vector[4] = "ESTADO";
                vector[5] = "NÚMERO DE INVESTIGADOR";

                while (par)
                {
                    while (true) // Bucle infinito para el menú
                    {
                        Console.WriteLine("-----------------MENÚ POCHIMON-----------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("1) Registrar un Pochimon.");
                        Console.WriteLine("2) Asignar investigador a Pochimon.");
                        Console.WriteLine("3) Actualizar nivel de Pochimon.");
                        Console.WriteLine("4) Marcar Pochimon como investigado.");
                        Console.WriteLine("5) Mostrar información de Pochimons.");
                        Console.WriteLine("6) Buscar Pochimons por su tipo.");
                        Console.WriteLine("7) Mostrar Pochimons por investigador.");
                    Console.WriteLine("8) Mostrar Pochimons superiores(nivel mayor a 30)");
                        Console.WriteLine("9) Salir.");

                    Console.WriteLine("elegi una opcion del menu");
                    opc = int.Parse(Console.ReadLine());
                        while (opc < 1 || opc > 9)
                        {
                        Console.WriteLine("ERROR!!!Elegi una opcion que este en el manu");
                        opc = int.Parse(Console.ReadLine());
                        }

                        // Llamar a la función correspondiente según la opción seleccionada
                        switch (opc)
                        {
                            case 1:
                                RegistrarPochimon();
                                break;
                            case 2:
                                AsignarInvestigador();
                                break;
                            case 3:
                                ActualizarNivel();
                                break;
                            case 4:
                                MarcarInvestigado();
                                break;
                            case 5:
                                MostrarInformacion();
                                break;
                            case 6:
                                BuscarPorTipo();
                                break;
                            case 7:
                                MostrarPorInvestigador();
                                break;
                            case 8:
                                  Mostrarsuperiores();
                                break;
                            case 9:
                                Console.WriteLine("chauchis...");
                                return; // Salir del programa    
                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                    }
                }
            }

            static void RegistrarPochimon()
            {
                if (val >= 76)
                {
                Console.WriteLine("La Pochidex está llena :(");
                    return;
                }

                Console.WriteLine("-----------------MENÚ REGISTRO-----------------");
                Console.Write("Ingrese nombre del Pochimon: ");
                nom = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de " + nom);
            Console.WriteLine("Fuego / Agua / Tierra/ Eléctrico /HADA");
            Console.WriteLine("(Coloque solo la inicial del tipo).");
            tipo = (Console.ReadLine()).ToUpper();
            while (tipo != "F" && tipo != "A" && tipo != "T" && tipo != "E" && tipo != "H") ;
            {
                Console.WriteLine("Coloque las letras correspondientes para asignar un tipo");
                tipo = (Console.ReadLine()).ToUpper();
            }

            Console.WriteLine(" ");
            Console.Write("Ingrese el nivel de " + nom + ": ");
            nivel = int.Parse(Console.ReadLine());

            while (nivel < 0 || nivel > 100)
            {
                Console.WriteLine("ERROR!!!. Ingrese un número entre el 1 y el 100");
                nivel = int.Parse(Console.ReadLine());
            }
            matriz[val, 0] = (val + 1).ToString();
            matriz[val, 1] = nom;

            if (tipo == "F")
            {
                tipo = ("FUEGO");
            }
            if (tipo == "A")
            {
                tipo = "AGUA";
            }
            if (tipo == "T")
            {
                tipo = "TIERRA";
            }

            if (tipo == "E")
            {
                tipo = "ELECTRICO";
            }
            if (tipo == "P")
            {
                tipo = "HADA";
            }

            matriz[val, 2] = tipo;
            matriz[val, 3] = nivel.ToString();
            matriz[val, 4] = "0";
            matriz[val, 5] = "000";
            val++;

            Console.Clear();
                Console.WriteLine("Pochimon registrado con éxito.");
            }

            static void AsignarInvestigador()
            {
                Console.Clear();

                if (val == 0)
                {
                   
                Console.WriteLine("Para asignarle un investigador primero tiene que estar registrado el pochimon en la pochidex!!!");
                Console.WriteLine("");
                    return; // Cambiado a return en lugar de break
                }

                Console.WriteLine("-----------------MENÚ ASIGNACION DE INVESTIGADOR-----------------");
                Console.WriteLine(" ");

                // Calcular la longitud máxima de los nombres de Pochimon
                int aux = matriz[0, 1].Length;

                for (int i = 1; i < val; i++)
                {
                    if (aux < matriz[i, 1].Length)
                    {
                        aux = matriz[i, 1].Length;
                    }
                }

                for (int i = 0; i < val; i++)
                {
                    matriz[i, 1] = matriz[i, 1].PadRight(aux);
                }

                // Mostrar encabezados
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(" " + vector[i] + "\t" + "|");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");

                // Mostrar la información de los Pochimons
                for (int i = 0; i < val; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(" " + matriz[i, j] + "\t" + "|");
                    }
                    Console.WriteLine();
                }

                // Pedir al usuario el número de fila del Pochimon a asignar
                Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                elecp = int.Parse(Console.ReadLine());
                while (elecp < 1 || elecp > val)
                {
                    Console.WriteLine("NO SE HA ENCONTRADO ESA FILA");
                    Console.WriteLine("POR FAVOR INGRESE UN NÚMERO DE FILA EXISTENTE");
                    elecp = int.Parse(Console.ReadLine());
                }

                // Pedir al usuario el código del investigador
                Console.Write("Ingrese el código del Investigador: ");
                while (!int.TryParse(Console.ReadLine(), out numinv))
                {
                    Console.WriteLine("Por favor, ingrese un código de investigador válido.");
                }

                // Asignar el investigador
                matriz[elecp - 1, 4] = "1"; // Marcar como investigado (cambiar a "1")
                matriz[elecp - 1, 5] = numinv.ToString(); // Guardar el número del investigador
                Console.Clear();
                Console.WriteLine("Investigador asignado con éxito.");
            }

            static void ActualizarNivel()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("-----------------MENÚ ACTUALIZACIÓN DE NIVEL-----------------");
                MostrarInformacion(); // Mostrar información para elegir el Pochimon

                Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
                elecp = int.Parse(Console.ReadLine());
                while (elecp < 1 || elecp > val)
                {
                    Console.WriteLine("NO SE HA ENCONTRADO ESA FILA");
                    Console.WriteLine("INGRESE UN NÚMERO DE FILA EXISTENTE");
                    elecp = int.Parse(Console.ReadLine());
                }

                Console.Write("Ingrese el nuevo nivel: ");
                nivel = int.Parse(Console.ReadLine());
                while (nivel < 0 || nivel > 100)
                {
                    Console.WriteLine("INCORRECTO. Un número entre el 0 y el 100");
                    nivel = int.Parse(Console.ReadLine());
                }

                matriz[elecp - 1, 3] = nivel.ToString(); // Actualizar el nivel en la matriz
                Console.Clear();
                Console.WriteLine("Nivel actualizado con éxito.");
            }

            static void MarcarInvestigado()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("-----------------MENÚ MARCAR COMO INVESTIGADO-----------------");
                MostrarInformacion(); // Mostrar información para elegir el Pochimon

                Console.Write("Ingrese el número de fila del Pochimon a marcar: ");
                elecp = int.Parse(Console.ReadLine());
                while (elecp < 1 || elecp > val)
                {
                    Console.WriteLine("NO SE HA ENCONTRADO ESA FILA");
                    Console.WriteLine("INGRESE UN NÚMERO DE FILA EXISTENTE");
                    elecp = int.Parse(Console.ReadLine());
                }

                matriz[elecp - 1, 4] = "1"; // Marcar como investigado
                Console.Clear();
                Console.WriteLine("Pochimon marcado como investigado.");
            }

            static void MostrarInformacion()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("-----------------INFORMACIÓN DE POCHIMONS-----------------");
                Console.WriteLine(" ");
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(" " + vector[i] + "\t" + "|");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");

                for (int i = 0; i < val; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(" " + matriz[i, j] + "\t" + "|");
                    }
                    Console.WriteLine();
                }
            }

            static void BuscarPorTipo()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("-----------------BUSQUEDA POR TIPO-----------------");
                Console.WriteLine("Ingrese el tipo a buscar (F/A/T/E/H): ");
                tipo = Console.ReadLine().ToUpper();

                while (tipo != "F" && tipo != "A" && tipo !=  "T"&& tipo != "E" && tipo !=  "H")
                {
                    Console.WriteLine("Coloque las letras correspondientes para buscar por tipo");
                    tipo = Console.ReadLine().ToUpper();
                }

                Console.WriteLine("Resultados de la búsqueda: ");
                bool encontrado = false;

                for (int i = 0; i < val; i++)
                {
                    if (matriz[i, 2] == (tipo switch // Uso de switch para simplificar el tipo
                    {
                        "F" => "FUEGO",
                        "A" => "AGUA",
                        "T"=> "TIERRA",
                        "E" => "ELECTRICO",
                        "H" => "HADA",
                       
                    }))
                    {
                        Console.WriteLine($"Fila {i + 1}: {matriz[i, 1]} - Nivel: {matriz[i, 3]}");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontraron Pochimons de ese tipo.");
                }
            }

            static void MostrarPorInvestigador()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("-----------------BUSQUEDA POR INVESTIGADOR-----------------");
                Console.Write("Ingrese el número del investigador: ");
                numinv = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultados de la búsqueda: ");
                bool encontrado = false;

                for (int i = 0; i < val; i++)
                {
                    if (matriz[i, 5] == numinv.ToString())
                    {
                        Console.WriteLine($"Fila {i + 1}: {matriz[i, 1]} - Tipo: {matriz[i, 2]} - Nivel: {matriz[i, 3]}");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontraron Pochimons asignados a ese investigador.");
                }
            }

            static void Mostrarsuperiores()
            {
                Console.Clear();

                if (val == 0)
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                    return;
                }

                Console.WriteLine("---------------- Pochimons superiores(nivel mayor a 30)----------------");
                bool encontrado = false;

                for (int i = 0; i < val; i++)
                {
                    if (matriz[i, 3] == "100") // Condición para Pochimons Messias
                    {
                        Console.WriteLine("Fila {i + 1}: {matriz[i, 1]} - Tipo: {matriz[i, 2]} - Nivel: {matriz[i, 3]}");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                Console.WriteLine("No hay Pochimons superiores(nivel mayor a 30)registrados");
                }
            }
        }
    }

namespace Actividad_1
{
    using System;
    using System.Collections.Generic;

    namespace PracticaUnidadII
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> nombres = new List<string>();
                List<int> edades = new List<int>();

                int cantidadPersonas = 0;

                
                while (true)
                {
                    Console.Write("Ingresa la cantidad de personas a registrar: ");
                    if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1)
                    {
                        break;
                    }
                    Console.WriteLine("Debes ingresar un número entero mayor o igual a 1");
                }

                
                for (int i = 0; i < cantidadPersonas; i++)
                {
                    Console.WriteLine("---- Nombre de la persona "+ (i+1) +" ----");

                    string nombre = Console.ReadLine();
                    nombres.Add(nombre);

                    int edad = 0;
                    // 4. Validación de la edad [cite: 10, 26]
                    while (true)
                    {
                        Console.Write("Edad: ");
                        if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                        {
                            edades.Add(edad);
                            break;
                        }
                        Console.WriteLine("Valor inválido. Por favor, ingresa una edad correcta");
                    }
                }

                Console.WriteLine("========================================");

                
                if (cantidadPersonas == 1)
                {
                    string edadpersona = (edades[0] >= 18) ? "es mayor de edad" : "es menor de edad";
                    Console.WriteLine("Resultado: " + nombres + " " + edadpersona);
                }
                
                else
                {
                    
                    Console.WriteLine("========= LISTA DE PERSONAS =========");
                    for (int i = 0; i < nombres.Count; i++)
                    {
                        Console.WriteLine( "Nombre: " + nombres[i] + " Edad: " + edades[i]);
                    }

                    
                    List<string> mayores = new List<string>();
                    List<string> menores = new List<string>();

                    for (int i = 0; i < nombres.Count; i++)
                    {
                        string persona = $"{nombres[i]} ({edades[i]} años)";
                        if (edades[i] >= 18) mayores.Add(persona); 
                        else menores.Add(persona); 
                    }

                    
                    if (mayores.Count > 0)
                    {
                        Console.WriteLine("--- PERSONAS MAYORES DE EDAD ---");
                        foreach (var p in mayores) Console.WriteLine(p);
                    }

                    if (menores.Count > 0)
                    {
                        Console.WriteLine("--- PERSONAS MENORES DE EDAD ---");
                        foreach (var p in menores) Console.WriteLine(p);
                    }
                }

                Console.WriteLine("========================================");
            }
        }
    }
}
using System;
using System.ComponentModel;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fundamentos de C#");
            Console.WriteLine("Tipo de dato");

            //1. Numero Entero
            int edad = 19;

            //2. Cadena Texto
            string nombre = "Juan";

            //3. Numero decimal
            double precio = 19.99;

            //4. Valor Logico
            bool estado = false;

            //5. Valor Caracter
            char genero = 'M';

            Console.WriteLine("Entrada Salida Comentario");

            //Entrada
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            //Salida
            Console.WriteLine($"Hola, {nombre}");

            // Comentario de 1 linea

            /*
              Comentario en Bloque
            */

            dotnet run Program.cs
        }
    }
}

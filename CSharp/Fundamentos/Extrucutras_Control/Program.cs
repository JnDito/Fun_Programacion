using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esturcturas de Control");
            // Secuencial
            string nombre;
            int edad;
            Console.WriteLine("Ingresa su nombre: ");
            nombre= Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");

            // Condicionales
            if ( edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            //doble
            if ( edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
            // Multiple
            Console.WriteLine("Ingresa un numero del 1 al 3: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ocion 1");
                    break;
                case 2:
                    Console.WriteLine("Ocion 2");
                    break;
                case 3:
                    Console.WriteLine("Ocion 3");
                    break;
                default:
                    Console.WriteLine("Ocion Invalida");
                    break;
            }
            
            // Anidado
            if(opcion == 1)
            {
                Console.WriteLine("Elegido Opcion 1");
            }
            else if(opcion == 2)
            {
                Console.WriteLine("Elegido Opcion 2");
            }
            else
            {
                Console.WriteLine("Elegido Opcion 3");
            }

            // Repetitivos
            // For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Numero: {i}");
            }

            // While
            int contador = 1;
            while(contador < 3)
            {
                Console.WriteLine($"Intento: {contador}");
                contador++;
            }

            // Do While
            int contador2 = 1;
            do
            {
                Console.WriteLine($"Intento: {contador2}");
                contador2++;

            } while (contador2 < 3);
        }
    }
}

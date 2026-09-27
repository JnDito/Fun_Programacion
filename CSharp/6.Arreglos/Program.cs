Console.WriteLine("Arreglos Unidimencionales");

// Declaro Arreglos
int[] numeros = new int[10];
numeros[1] = 26;
numeros[9] = 11; // Inserta en la posicion 9 al 11

// Mostrar el arreglo
Console.WriteLine(string.Join(", ", numeros));

// Declarar un arreglo de nombres
string[] nombres = new string[5];
nombres[0] = "Juan";
nombres[4] = "Susana";
Console.WriteLine(string.Join(", ", nombres));

// Elementos e indice de un arreglo
Console.WriteLine($"Cantidad: {numeros.Length}");
Console.WriteLine($"Ultimo Elemento: {numeros[numeros.Length - 1]}");

// El valor en un indice especifico
Console.WriteLine($"Nombre en la posicion 4 es: {nombres[4]}");
Console.WriteLine($"Numero en la posicion 9 es: {numeros[9]}");

// Recorrer el arreglo
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Posicion {i}: Valor: {numeros[i]}");
}

for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine($"Posicion {i}: Valor: {nombres[i]}");
}

// Declarar un arreglo bidimencional (Matriz)

int[,] notas = 
{
    {1, 2, 3, 4}, // Arreglo 1
    {5, 6 ,7, 8}, // Arreglo 2
    {9, 10, 11, 12} //Arreglo 3
};

// Mostrar elemento fila 1, columna 3 (debe mostrar el numero 8)
Console.WriteLine(notas[1,3]);

// Recorrer la matriz
for (int filas = 0; filas < notas.GetLenght(0); filas++)
{
    for (int columnas = 0; columnas < notas.GetLenght(1); columnas++)
    {
        Console.WriteLine($"Fila: {filas}, Columna: {columnas} - Valor: {notas[filas,columnas]}");
    }
}

Console.WriteLine("Operacion con Arreglos");
// Insercion

// Busqueda

// Modificacion

// Eliminacion
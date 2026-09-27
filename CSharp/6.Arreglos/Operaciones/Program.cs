Console.WriteLine("Operacioes con Arreglos");
Console.WriteLine("Operaciones INSERCION");
// Insercion en una posicion especifica
List<string> productos = new List<string> {"Teclado", "Mouse", "Laptop"};
productos.Insert(1, "Parlantes");
Console.WriteLine(string.Join(", ", productos));

// Insercion al final de la lista
productos.Add("Refrigeradora");
Console.WriteLine(string.Join(", ", productos));

// Insercion Multiple
productos.AddRange(new List<string> {"Hp", "Dell", "Asus", "Lenovo", "Hp"});
Console.WriteLine(string.Join(", ", productos));

Console.WriteLine("Operaciones BUSQUEDA");
// Busqueda
if (productos.Contains("Hp"))
{
    int posicion = productos.IndexOf("Hp");
    Console.WriteLine($"Encontrado en la posicion: {posicion}");
}
else
{
    Console.WriteLine("Producto no encontrado");
}

// Equivalen in
Console.WriteLine($"Contiene el producto HP: {productos.Contains("Hp")}");
// Primera posicion
Console.WriteLine($"HP se encuentra en la posicion: {productos.IndexOf("Hp")}");
// Cantidad de repeticiones
Console.WriteLine($"Productos HP se repite: {productos.Count(x => x == "Hp")} veces");

Console.WriteLine("Operaciones MODIFICACION");
// Modificacion en posicion
productos[5] = "NVidia";
Console.WriteLine(string.Join(", ", productos));

// Modificaion masiva
List<double> notas = new List<double> {12.9, 14.3, 19.1, 11.49};
for (int i = 0; i < notas.Count; i++)
{
    notas[i] = notas[i] + 0.9;
}
Console.WriteLine(string.Join(", ", notas));

// Modificacion por segmento
for (int j = 0; j <= 3; j++)
{
    productos[j] = productos[j].ToUpper();
}
Console.WriteLine(string.Join(", ", productos));

// Modificacion Transformacion masiva
List<double> salarios = new List<double> {2000, 1560, 2700, 4000};
salarios = salarios.Select(salario => salario > 1900 ? salario * 1.1: salario).ToList();
Console.WriteLine(string.Join(", ", salarios));

Console.WriteLine("Operaciones ELIMINACION");
// Eliminacion de un valor
productos.Remove("Refrigeradora");
Console.WriteLine(string.Join(", ", productos));

// Eliminacion por un indice
productos.RemoveAt(1);
Console.WriteLine(string.Join(", ", productos));

// Eliminacion por rango 
productos.RemoveRange(1,2);
Console.WriteLine(string.Join(", ", productos));

// ELimicacion por criterio
List<int> datos = new List<int> {11, 11, 20, 18, 11, 20, 17, 16};
datos.RemoveAll(x => x == 11);
Console.WriteLine(string.Join(", ", datos));

// Vaciar la lista
salarios.Clear();
Console.WriteLine(string.Join(", ", salarios));
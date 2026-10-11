

Console.WriteLine("Arreglo de Cadenas en C#");

// Sintaxis
string texto = "Fundamentos de Programación";
Console.WriteLine(texto);
Console.WriteLine(texto[0]);
Console.WriteLine(texto[7]);

// Connadenar cadenas
string nombre = "Juan";
string apellido = "Vasquez";
string nombre_competo = nombre + " " + apellido;
Console.WriteLine(nombre_competo);

// Longitud de una cadena
int cantidad = texto.Length;
Console.WriteLine($"Longitud de cadena: {cantidad}");
Console.WriteLine($"Ultimo caracter: {texto[texto.Length - 1]}");

// Recorrer una cadenas en C#
for (int i = 0; i < texto.Length; i++)
{
    Console.WriteLine($"{i} -> {texto[i]}");
}

Console.WriteLine("Metodo para Trabajar Cadenas");
// Find --> IndexOf
string texto1 = "Apellidos,Nombre";
int posicionComa = texto1.IndexOf(",");
Console.WriteLine($"Posicion de la coma: {posicionComa}");

// Slicing --> SubString
string email = "juan.perez@upe.pe";
// Ubicar la posicion del "@"
int posicionArroba = email.IndexOf("@");
string usuario = email.Substring(0, posicionArroba);
string dominio = email.Substring(posicionArroba + 1);
Console.WriteLine($"Usuario: {usuario}");
Console.WriteLine($"Dominio: {dominio}");

// Split --> Split
string nombrecompleto = "Ana Maria Arribasplata Lozano";
string[] partes = nombrecompleto.Split(' ');
// Console.WriteLine(partes);
Console.WriteLine($"Primera parte: {partes[0]}");
Console.WriteLine($"Segunda parte: {partes[1]}");
Console.WriteLine($"Tercera parte: {partes[2]}");
Console.WriteLine($"Cuarta parte: {partes[3]}");

// Replace --> Replace
string num_movil = "+52-1-456-789-6548";
string num_movil_limpio = num_movil.Replace("-", "");
Console.WriteLine($"Numero movil con '-': {num_movil}");
Console.WriteLine($"Numero movil sin '-': {num_movil_limpio}");

// Upper --> ToUpper
string mayuscula = nombrecompleto.ToUpper();
Console.WriteLine($"En mayuscula: {mayuscula}");

// Lower --> ToLower
string minuscula = nombrecompleto.ToLower();
Console.WriteLine($"En minuscula: {minuscula}");

// Strip --> Trim
string cadena = "           Diana Reyes               ";
string cadena_limpia = cadena.Trim();
Console.WriteLine($"Cadena con espacios inicio y fin: [{cadena}]");
Console.WriteLine($"Cadena sin espacios inicio y fin: [{cadena_limpia}]");
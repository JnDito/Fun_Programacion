Console.WriteLine("Modularidad");
// modulo --> funcion especifica
// Calcula Producto

static string leer_producto()
{
    Console.WriteLine("Ingresa nombre del producto: ");
    return Console.ReadLine();
}
static double leer_precio()
{
    Console.WriteLine("Ingrese precio de un producto: ");
    return double.Parse(Console.ReadLine());
}
static double calcula_igv(double precio)
{
    return precio * 0.18;
}
static void mostrar_resultados(string nombre, double precio, double igv)
{
    double total = precio + igv;
    Console.WriteLine($"Producto: {nombre}");
    Console.WriteLine($"Precio: {precio}");
    Console.WriteLine($"IGV: {igv}");
    Console.WriteLine($"Total a pagar: {total}");
}
string nombre = leer_producto();
double precio = leer_precio();
double igv = calcula_igv(precio);
mostrar_resultados(nombre, precio, igv);
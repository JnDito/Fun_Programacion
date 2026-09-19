Console.WriteLine("-- Tipos de Variables --");
Console.WriteLine("Variable Local");
static void saludar()
{
    string nombre = "Juan";
    Console.WriteLine($"Hola {nombre}, bienvenido");
}

saludar();
Console.WriteLine("---------------------------");

Console.WriteLine("Variable Global - Compartida");
int incrementar = 0;

void incrementa()
{
    incrementar += 20;
    Console.WriteLine($"Valor de la variable global: {incrementar}");
}

incrementa();
Console.WriteLine("---------------------------");
Console.WriteLine("Variable No Local");

static void calcularmonto()
{
    double subtotal = 100;
    double calcular_igv(double a)
    {
        return a * 0.18;
    }
    double resultado = calcular_igv(subtotal);
    Console.WriteLine($"El total a pagar es: {resultado + subtotal}");
}

calcularmonto();
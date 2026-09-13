# Declarar una funcion
# def saludar(a, b, c); --> son parematros
def saludar():
    print("Bienvenido al curso de Fundamentos de Programación")

# Invocar o Llamar a una funcion
saludar()
# saludar(1, 2, 3) --> son argumentos

## Declarar una funcion sin retorno
def menu():
    print("1. Registrar")
    print("2. Buscar")
    print("1. Salir")

menu()

## Declarar funcion con retorno
def producto(a, b):
    return a * b

# Llamar a funcion retorno pasando argumentos
resultado = producto(8, 7)
print(f'{resultado}, Resultado*2 = {resultado*2}')

## Funcion con varios argumentos
def prometio(T1, T2, T3, EP, EF):
    return T1 * 0.1 + T2 * 0.1 + T3 * 0.1 + EP * 0.2 + EF * 0.5

resultado1 = prometio(20, 20, 20, 14, 12)
print(f'Tu promedio final es {resultado1}')

## Declarar Funciones con parametros determinados
## ----------------------------------

def saludar_estudiantes(nombre, curso='Fundamentos de Programación'):
    print(f'Hola, {nombre}, Bienvenido a, {curso}')

saludar_estudiantes('Juan')
saludar_estudiantes('Juan', 'Base de Datps')

## Funciones Anidadas
## ----------------------------------
def proceso_compra(monto):
    def aplicar_igv(valor):
        return valor * 0.18
    igv = aplicar_igv(monto)
    total = monto + igv
    return total

resultado2 = proceso_compra(550)
print(f'Total a pagar con IGV es: S/. {resultado2}')

## Funciones Paso Parametros por Valor
## ----------------------------------
def incrementar_valor(numero):
    numero = numero + 5
    print(f"Dentro de la Funcion: {numero}")

x = 15
incrementar_valor(x)
print(f"Fuera de la Funcion: {x}")

## Funciones Paso Parametros por Referencia
## ----------------------------------
def añadir_productos(productos):
    productos.append("Laptop")
    print(f"Dentro Funcion: {productos}")

lista_productos = ["Impresora", "Ipad", "Iphone"]
añadir_productos(lista_productos)
print(f"Fuera de la funcion: {lista_productos}")
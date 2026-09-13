# Modulo --> Funcion especifica

## Calcular Productos

def  leer_producto():
    return input("Ingrese un producto: ")

def leer_precio():
    return float(input("Ingrese un precio: "))

def calcular_igv(precio):
    return precio * 0.18

def resutados(nombre, precio, igv):
    total = precio + igv
    print(f"El producto {nombre}")
    print(f"El precio es: {precio}")
    print(f"El IGV es: {igv}")
    print(f"El total es: {total}")

nombre = leer_producto()
precio = leer_precio()
igv = calcular_igv(precio)
resutados(nombre, precio, igv)
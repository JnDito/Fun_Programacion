## VAriables Locales
def saludar():
    nombre = "Juan"
    print(f"Hola, {nombre}, Bienvenido")

saludar()
## print(nombre)
## Variables Globales
edad = 25

def mostrar_edad():
    global edad
    print(f"Tu edad es: {edad}")

mostrar_edad()
print(type(edad))

## Variable No Local

def principal():
    subtotal = 0

    def calcularmonto():
        nonlocal subtotal
        subtotal += 100
        print(f"El nuevo valor es: {subtotal}")

    calcularmonto()
    print(f"El nuevo valor en Principal es: {subtotal}")

principal()
# Estructura Secuenciales
print("Registro Basico")
nombre = input("Ingrese su nombre: ")
edad = int(input("Ingrese su edad: "))
print(f"Nombre: {nombre} , Edad: {edad}")

# Estructuras Condicionales
# Condicional Simple
print("Validad edad: ")
if edad < 18:
    print("Eres menor de edad") 
# Condicional doble

if edad > 17:
    print("Eres mayor de edad")
else:
    print("Eres menor de edad...")

# Condicional Multiple
opcion = int(input('Ingrese un numero del 1 al 3: '))
match opcion:
    case 1:
        print("La primera opcion")
    case 2:
        print("La segunda opcion")
    case 3:
        print("Tercera opcion")
    case _:
        print("Opcion no valida")

# Condicional anidado
if opcion == 1:
    print("Opcion 1")
elif opcion == 2:
    print("Opcion 2")
else:
    print("Opcion 3")

# Estructuras Repetitivas
# For - Para
# Genera numero del 1 al 5
for i in range(1, 6):
    print(f"Repeticion numero: {i}")

# While - Mientras
contador = 1
while contador <= 3:
    print(f"Intento: {contador}")
    contador += 1
# Do While - Hacer Mientras
while True:
    numero = int(input("Ingresa un numero > 0: "))
    if numero > 0:
        break
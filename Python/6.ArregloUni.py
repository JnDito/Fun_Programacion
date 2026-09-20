# Declarando un arreglo

valores = [0, 0, 0, 0]
print(valores)

# Insertanto un valor en una posición
valores[1] = 25

# Mostrar Arreglo
print(valores)

# Tipo dato arreglo
print(type(valores))

# Longitud de un Arreglo
print(f'La longitud es {len(valores)}')

# Quiero conocer el ultimo elemento
print(f'{valores[len(valores) - 1]}')

# Arreglos de Nombres
nombres = ['Juan', 'Maria', 'Jose', 'Pedro', 'Luis']
print(nombres)
print(f'Cantidad de nombres guardados: {len(nombres)}')
print(f'Ultimo nombre guardado: {nombres[len(nombres) - 1]}')

edades = [23, 14, 18, 25, 17]
print(f'Elemento en la posición 1: {edades[1]}')
print(f'Elemento en el indice 4: {edades[4]}')

## Recorrer un array - arreglo - lista - vector
notas = [14, 15, 18, 10, 12, 11]

for i in range(len(notas)):
    print(f'Posicion: {i}, Valor: {notas[i]}')

print(nombres)
for k in range(len(nombres)):
    print(f'Elemento: {k + 1}, Valor: {nombres[k]}')

## Operaciones Inserciún, Busqueda, Modificación y Eliminación

# Insercion
# Final de un arreglo - append()
productos = ['Teclado', 'Mouse', 'Monitor', 'Laptop']
productos.append("Celular Tactial")
print(productos)

# Insertar posicion especifica - insert
productos.insert(1, "Iphone")
print(productos)

# Insertar Valios Elementos - extend()
productos.extend(['hp', 'TV', 'Asus', 'Refrigeradora', 'TV'])
print(productos)

# --- Busqueda ----
if 'TV' in productos:
    posicion = productos.index('TV')
    print(f'Encontrado en la posicion: {posicion}')
else:
    print(f'El elemento TV no encontrado')

print(productos.index('TV'))
print(productos.count('TV'))

# --- Modificar Elemento ---
productos[7] = 'Licuadora'
print(productos)

for k in range(len(productos)):
    if productos[k] == 'Refrigeradora':
        productos[k] = 'Audiculares'
print(productos)
print(notas)

# Reemplaza por cero a notas menor a 11
for i in range(len(notas)):
    if notas[i] < 11:
        notas[i] = 0
print(notas)

# Suma + 1 a cada nota -- modificacion masiva
for i in range(len(notas)):
    notas[i] = notas[i] + 1
print(notas)

# Modificacion por segmento - upper, colocar en mayusculas
productos[1:3] = [producto.upper() for producto in productos[1:3]]
print(productos)

# Modificacion por listas
precios = [35, 80, 74, 99]

precios = [precio * 0.9 if precio > 70 else precio for precio in precios]
print(precios) 

# --- Elimicacion ---
#Eliminar valor
productos.remove('Licuadora')
print(productos)

# Eliminar por indice - pop()
eliminado = productos.pop(2)
print(eliminado)
print(productos)

# Eliminar por segmento (Rango definido)
del productos[1:3]
print(productos)

# Eliminacion masiva
notas = [x for x in notas if x > 12]
print(notas)

# Vaciar lista
notas.clear()
print(notas)
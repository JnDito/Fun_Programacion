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

for k in range(len(nombres)):
    print(f'Elemento: {k + 1}, Valor: {nombres[k]}')


## Arreglos Bidimencionales - Matrices - Tablas
# Declarar una Matriz

matriz = [
    [1, 2, 3],  # Fila 1
    [4, 5, 6]   # Fila 2
]

print(matriz)
print(type(matriz))

# Buscar un elemento en la posición especifica
matriz2 = [
    [1, 2, 3, 4, 5],
    [6, 7, 8, 9, 10],
    [11, 12, 13, 14, 15]
]

print(matriz2[1][2])

# Recorrer la matriz
for i in range(len(matriz2)):
    for j in range(len(matriz2[i])):
        print(f'Fila: {i}, Columna: {j}, Valor: {matriz2[i][j]}')
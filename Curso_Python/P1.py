# Crear la lista con el elemento repetido
lista = [1, 2, 3, 4, 4, 4, 5, 6]

# Buscar el elemento repetido
repetido = None
for elemento in lista:
    if lista.count(elemento) >= 3:
        repetido = elemento
        break

# Eliminar el elemento si es diferente a la primera posición
if repetido is not None:
    if lista[0] != repetido:
        lista = [x for x in lista if x != repetido]

# Imprimir la lista resultante
print(lista) 

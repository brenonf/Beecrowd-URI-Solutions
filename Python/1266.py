while True:
    n = int(input())
    if n == 0:
        break

    lista = list(map(int, input().split()))
    lista2 = lista[::-1]

    estacas = 0
    estacas2 = 0
    cont = 0

    for i in range(n):
        if lista[i] == 0:
            cont += 1
        elif lista[i] == 1:
            cont = 0

        if cont >= 2:
            cont = 0
            estacas += 1
            lista[i] = 1

    if lista[0] == 0:
        cont += 1
    elif lista[0] == 1:
        cont = 0

    if cont >= 2:
        cont = 0
        estacas += 1

    cont = 0

    for i in range(n):
        if lista2[i] == 0:
            cont += 1
        elif lista2[i] == 1:
            cont = 0

        if cont >= 2:
            cont = 0
            estacas2 += 1
            lista2[i] = 1

    if lista2[0] == 0:
        cont += 1
    elif lista2[0] == 1:
        cont = 0

    if cont >= 2:
        cont = 0
        estacas2 += 1

    print(min(estacas, estacas2))

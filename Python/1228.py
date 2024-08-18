while True:
    try:
        n = int(input())
    except EOFError:
        break
    
    inicio = list(map(int, input().split()))
    fim = list(map(int, input().split()))

    cont = 0
    indice2 = 0

    while inicio != fim:
        indice1 = inicio.index(fim[indice2])
        cont += abs(indice2 - indice1)
        inicio.insert(indice2, inicio.pop(indice1))

        indice2 = (indice2 + 1) % n


    print(cont)

n = int(input())

for _ in range(n):
    lista1 = list(map(int, input().split()))
    lista2 = list(map(int, input().split()))

    valor = 99999999
    item = 0

    for j in range(len(lista2)):
        if abs(lista2[j] - lista1[1]) < valor:
            item = j
            valor = abs(lista2[j] - lista1[1])

    print(item + 1)

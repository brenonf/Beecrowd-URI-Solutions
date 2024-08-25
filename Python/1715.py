cont = 0

n = list(map(int, input().split()))
lista = [0] * n[1]
for _ in range(n[0]):
    lista = list(map(int, input().split()))
    if 0 not in lista:
        cont += 1



print(cont)

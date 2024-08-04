while True:
    n = int(input())
    if n == 0:
        break
    lista = list(map(int, input().split()))
    #cont=0
    if len(lista) == 1:
        print(10)
    else:
        t = 10
        for i in range(n - 1):
            if lista[i + 1] - lista[i] < 10:
                t += lista[i + 1] - lista[i]
            else:
                t += 10
        print(t)

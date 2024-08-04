while True:
    n=int(input())
    if n==0:
        break
    sobra=0
    for i in range(n):
        lista = list(map(int, input().split()))
        if lista[1]%2 == 0:
            sobra+=lista[1]
        else:
            sobra+=lista[1] - 1
    print(sobra//4)

n = int(input())
lista = list(map(int, input().split()))
Sn = ((1 + n) * n) // 2
Sn2 = sum(lista)
print(Sn - Sn2)

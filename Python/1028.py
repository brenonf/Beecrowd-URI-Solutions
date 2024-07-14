def mdc(a, b):
    while b != 0:
        a, b = b, a % b
    return a

n = int(input())
for i in range(n):
    ri,vi = list(map(int,input().split()))

    saida = mdc(ri,vi)
    print(saida)
cont=0

while True:
    n = int(input())
    if n == 0:
        break
    cont+= 1
    nome1 = input()
    nome2 = input()
    print(f'Teste {cont}')

    for i in range(n):
        jogada = sum(map(int, input().split()))
        if jogada%2==0:
            print(nome1)
        else:
            print(nome2)
    print()

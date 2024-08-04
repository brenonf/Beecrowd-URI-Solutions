cont=1
while True:
    n=int(input())
    if n==0:
        break
    
    lista =list(map(int,input().split()))
    for i in range(n):
        if(i+1==lista[i]):
            print(f'Teste {cont}')
            cont+=1
            print(i+1)
            print()
            break
            
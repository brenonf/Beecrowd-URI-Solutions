n = int(input())
for i in range(0,n):
    a = input().split()
    x,y=a
    x= int(x)
    y=int(y)
    soma = 0
    j = 1
    while j <= y:
        if x % 2 != 0:
            soma = soma + x
            
            x = x + 1
            j = j + 1
        if x % 2 == 0:
            x = x + 1
    print(soma)
            

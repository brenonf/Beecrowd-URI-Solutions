def fat(n,k):
    x=n
    aux=1
    while (n-k*aux)>=1:
        x*=(n-k*aux)
        aux+=1
    return x
        

for i in range(int(input())):
    n=input()
    aux = n.count('!')
    n=int(n.replace('!',''))
    print(fat(n,aux))

while True:
    n=int(input())
    if(n==0):
        break
    lista = list()
    lista.append(n)
    while n!=1:
        if n%2==0:
            n=n/2
        else:
            n=n*3+1
        lista.append(n)
    print(int(max(lista)))
    
    


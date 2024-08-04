while True:
    t,n=list(map(int,input().split()))
    if n==0 and t==0:
        break
    pontos=0
    for i in range(t):
        pontos+=int(input().split()[1])
    if(pontos==3*n):
        print(0)
    else:
        print(3*n-pontos)
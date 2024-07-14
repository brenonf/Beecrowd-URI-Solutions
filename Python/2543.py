while True:
    try:
        cont=0
        a,b=list(map(int,input().split()))
        for i in range(a):
            c,d=list(map(int,input().split()))
            if c == b and d==0:
                cont+=1
    except EOFError:
        break
    print(cont)
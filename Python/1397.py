while True:
    n= int(input())
    if n==0:
        break
    A=0
    B=0
    for i in range(n):
        a,b=list(map(int,input().split()))
        if a>b:
            A+=1
        elif a<b:
            B+=1
    print(f'{A} {B}')
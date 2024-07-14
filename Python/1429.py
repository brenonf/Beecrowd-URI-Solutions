def fat(x):
    aux=0
    for i in range(x-1,0,-1):
        x*=i
    return x


while True:
    n=input()
    l=len(n)
    acm=0
    if n=='0':
        break
    for i in n:
        acm+=int(i)*fat(l)
        l-=1
    print(acm)
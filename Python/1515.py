while True:
    soma=9999
    n=int(input())
    if(n==0):
        break
    
    for i in range(n):
        planeta = input().split()
        if(int(planeta[1])- int(planeta[2])<soma):
            soma=int(planeta[1])- int(planeta[2])
            msg=planeta[0]
    print(msg)
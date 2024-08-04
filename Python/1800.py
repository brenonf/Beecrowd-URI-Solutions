n = list(map(int,input().split()))
foi = list(map(int,input().split()))

for i in range(n[0]):
    x=int(input())
    if(x in foi):
        print(0)
    else:
        print(1)
        foi.append(x)
        

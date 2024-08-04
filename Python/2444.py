n = list(map(int,input().split()))
m = list(map(int,input().split()))

for item in m:
    n[0]+=item
    if(n[0]>100):
        n[0]=100
    elif(n[0]<0):
        n[0]=0
print(n[0])
        

n =list(map(int,input().split()))

cont=0
seg=0

while(seg<n[1]):
    seg+=n[1]- n[0]
    cont+=1
print(cont)

////////
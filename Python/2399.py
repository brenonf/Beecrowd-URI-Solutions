n = int(input())
listao=[]

for i in range(n):
    listao.append(int(input()))

if(n==1):
    print(listao[0])
else:
    print(listao[0]+listao[1])
    for i in range(1,n-1):
        print(listao[i-1]+listao[i]+listao[i+1])
    print(listao[n-1]+listao[n-2])
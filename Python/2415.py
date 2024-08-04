n =int(input())
cont=1
maior=-999

listao =list(map(int,input().split()))
for i in range(n-1):
    if listao[i]==listao[i+1]:
        cont+=1
    else:
        maior=max(maior,cont)
        cont=1
maior=max(maior,cont)
print(maior)

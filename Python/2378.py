soma=0
peso="N"
n=list(map(int,input().split()))
for i in range(n[0]):
    mov=list(map(int,input().split()))
    soma-=mov[0]
    soma+=mov[1]
    if(soma>n[1]):
        peso="S"
print(peso)
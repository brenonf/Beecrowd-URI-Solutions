n=list(map(int,input().split()))
pontos=list()
for i in range(n[0]):
    pontos.append(0)



lista= list(map(int,input().split()))

for i in range(n[1]):
    for j in range(n[0]):
        pontos[j]+=lista[j+i*n[0]]
maximo=max(pontos)

#for i in range(len(pontos)-1,-1):
for i in range(len(pontos)-1,-1,-1):
    if pontos[i]==maximo:
        print(i+1)
        break
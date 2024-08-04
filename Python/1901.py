n=int(input())
listao =set()
floresta=[]
for i in range(n):
    floresta.append(list(map(int,input().split())))
for i in range(2*n):
    celula =  list(map(int,input().split()))
    listao.add(floresta[celula[0]-1][celula[1]-1])
print(len(listao))
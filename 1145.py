x,y = map(int,input().split())

n = []
i = 0
k = 0
while i < y-x:
    for j in range(1, x + 1):
        n.append(i + 1)
        aux = n[k]
        n[k] = str(n[k])
        k = k + 1
        i = i + 1
    
    k = 0
    n = ' '.join(n)
    print(n)
    n =[]
z = y%x

if z ==0:
    for w in range(y - x,y):
        n.append(w + 1)
        n[k] = str(n[k])
        k = k + 1
    n = ' '.join(n)
    print(n)
if z !=0:
    for w in range(aux,y):
        n.append(w + 1)
        n[k] = str(n[k])
        k = k + 1
    n = ' '.join(n)
    print(n)

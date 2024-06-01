m=[]
l = input()

for i in range(12):
    m.append([])
    for j in range(12):
        x = float(input())
        m[i].append(x)

s = 0
inf = 1
sup = 11
cont = 0
for i in range(0,5):
    for j in range(inf,sup):
        s += m[i][j]
        cont += 1
    inf += 1
    sup -= 1

med = s / cont

if l == "S":
    print('{:.1f}'.format(s))
else:
    print('{:.1f}'.format(med))
    

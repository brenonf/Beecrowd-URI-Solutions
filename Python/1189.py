m=[]
l = input()

for i in range(12):
    m.append([])
    for j in range(12):
        x = float(input())
        m[i].append(x)

s = 0
cont = 0
col = 1
for i in range(1,11):
    for j in range(0,col):
        s += m[i][j]
        
        cont += 1
    if i < 5:
        col += 1
    if i > 5:
        col -= 1
    
    

med = s / cont

if l == "S":
    print('{:.1f}'.format(s))
else:
    print('{:.1f}'.format(med))

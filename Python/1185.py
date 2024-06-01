m=[]
letra = input()

for i in range(12):
    m.append([])
    for j in range(12):
        x = float(input())
        m[i].append(x)
c = 12
s = 0
cont = 0
for i in range(11):
    c -=1
    for j in range(c):
        s += m[i][j]
        cont += 1

if letra == 'S':
    print('{}'.format(s))

if letra == 'M':
    med = s / cont
    print('{:.1f}'.format(med))
    

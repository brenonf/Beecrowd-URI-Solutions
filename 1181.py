l = int(input())
opera = input()
   

m=[]
for i in range(12):
    m.append([])

for i in range(12):
    for j in range(12):
        x = float(input())
        m[i].append(x)
        

if opera == 'S':
    soma = 0
    for k in m[l]:
        soma = soma + k
    print(soma)
if opera == 'M':
    med = 0
    soma = 0
    for k in m[l]:
        soma = soma + k
    med= soma/12
    print(med)

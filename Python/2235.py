x = input().split()
for i in range(len(x)):
    x[i] = int(x[i])

x.sort()

a,b,c =x

if a + b == c or a==b or a==c or b==c:
    print('S')
else:
    print('N')

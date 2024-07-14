x = input().split()
for i in range(3):
    x[i] = int(x[i])
x.sort()
a,b,c = x

if abs(b - c) < a < (b + c) and abs(a - c) < b < (a + c) and abs(a - b) < c < (a + b):
    if a==b==c:
        print('Valido-Equilatero')
    if (a==b and b!=c) or (a==c and b!=c) or (b==c and a!=b):
        print('Valido-Isoceles')
    if (a!=b!=c):
        print('Valido-Escaleno')
    if c**2 ==(b**2 + a**2):
        print('Retangulo: S')
    if c**2 !=(b**2 + a**2):
        print('Retangulo: N')
else:
    print("Invalido")

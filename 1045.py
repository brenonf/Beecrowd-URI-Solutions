x = input().split()
a, b, c = x

n1 = float(1)
n2 = float(1)
n3 = float(1)
a = float(a)
b = float(b)
c = float(c)

if a >= b and a >= c:
    n1 = a
    if b >= c:
        n2 = b
        n3 = c
    else:
        n2 = c
        n3 = b
if b >= a and b >= c:
    n1 = b
    if a >= c:
        n2 = a
        n3 = c
    else:
        n2 = c
        n3 = a

if c >= a and c >= b:
    n1 = c
    if a >= b:
        n2 = a
        n3 = b
    else:
        n2 = b
        n3 = a             

if a == b and b == c:
    n1=a
    n2=b
    n3=c

a = n1
b = n2
c = n3

if a >= (b + c):
    print('NAO FORMA TRIANGULO')
else:
    if (a ** 2) == (b ** 2 + c ** 2):
        print('TRIANGULO RETANGULO')
    if (a ** 2) > (b ** 2 + c ** 2):
        print('TRIANGULO OBTUSANGULO')
    if (a ** 2) < (b ** 2 + c ** 2):
        print('TRIANGULO ACUTANGULO')
    if (a == b == c):
        print('TRIANGULO EQUILATERO')
    if a == b != c or b == c != a or a == c != b:
        print('TRIANGULO ISOSCELES')

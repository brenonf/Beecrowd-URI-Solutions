x =input().split()
a, b, c = x
pi = 3.14159

tri = ((float(a) * float(c) )/ 2)
cir = (pi * float(c)**2)
tra = (float(c) * ((float(a) + float(b)) / 2))
qua = (float(b)**2)
ret = (float(a) * float(b))

print('TRIANGULO: {:.3f}'.format(tri))
print('CIRCULO: {:.3f}'.format(cir))
print('TRAPEZIO: {:.3f}'.format(tra))
print('QUADRADO: {:.3f}'.format(qua))
print('RETANGULO: {:.3f}'.format(ret))

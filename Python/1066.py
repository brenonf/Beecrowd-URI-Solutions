a = int(input())
b = int(input())
c = int(input())
d = int(input())
e = int(input())

par=0
imp=0
po=0
ne=0

for n in [a,b,c,d,e]:
  if n % 2 ==0:
    par = par + 1
  else:
    imp = imp + 1
  if n > 0:
    po = po + 1
  if n < 0:
    ne = ne+1

print('{} valor(es) par(es)'.format(par))
print('{} valor(es) impar(es)'.format(imp))
print('{} valor(es) positivo(s)'.format(po))
print('{} valor(es) negativo(s)'.format(ne))

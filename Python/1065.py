a = int(input())
b = int(input())
c = int(input())
d = int(input())
e = int(input())

s=0

for n in [a,b,c,d,e]:
  if n % 2 ==0:
    s = s + 1
print('{} valores pares'.format(s))

lista = [ 40320,5040,720,120,24,6,2, 1]

n = int(input())
cont=0
for i in lista:
    cont+= n//i
    n%=i
print(cont)

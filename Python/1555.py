def rafael(x,y):
    z=(3*x)**2+y**2
    return z

def beto(x,y):
    z=2*(x)**2+(5*y)**2
    return z

def carlos(x,y):
    z=-100*x+y**3
    return z

for i in range(int(input())):
    x,y=list(map(int,input().split()))
    aux=0
    nome=''
    if rafael(x,y) >aux:
        aux= rafael(x,y)
        nome='Rafael ganhou'
        
    if beto(x,y)> aux:
        aux=beto(x,y)
        nome='Beto ganhou'

    if carlos(x,y)>aux:
        aux=carlos(x,y)
        nome='Carlos ganhou'

    print(nome)
        
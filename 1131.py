x=1
grenais = 0
inter = 0
gremio = 0
empate = 0


while x == 1:
    y = input().split()
    a,b=y
    a=int(a)
    b=int(b)
    grenais = grenais + 1
    if a > b:
        inter = inter + 1
    if a < b:
        gremio = gremio + 1
    if a == b:
        empate = empate + 1
    while True:
        x = int(input('Novo grenal (1-sim 2-nao)'))
        if x == 2 or x == 1:
            break
print('{} grenais'.format(grenais))
print('Inter:{}'.format(inter))
print('Gremio:{}'.format(gremio))
print('Empates:{}'.format(empate))
if inter > gremio:
    print('Inter venceu mais')
if gremio > inter:
    print('Gremio venceu mais')
if gremio == inter:
    print('Nao houve vencedor')
    

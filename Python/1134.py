al = 0
ga = 0
di = 0
x = 0
while x != 4:
    x = int(input())
    if x == 1:
        al = al + 1
    if x == 2:
        ga = ga + 1
    if x == 3:
        di = di + 1
print('MUITO OBRIGADO')
print('Alcool: {}'.format(al))
print('Gasolina: {}'.format(ga))
print('Diesel: {}'.format(di))

p, j1, j2, r, a =map(int,input().split())

resultado = j1 + j2

if resultado % 2 == 0:
    resultado = 'par'
else:
    resultado = 'impar'

if p == 1:
    if resultado == 'par':
        win = 1
    else:
        win = 2
        
elif p == 0:
    if resultado == 'impar':
        win = 1
    else:
        win = 2

if a == 1 == r:
    win = 2
elif a == 0  and r == 1:
    win = 1

print('Jogador {} ganha!'.format(win))

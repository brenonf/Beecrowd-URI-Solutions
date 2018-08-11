x = input().split()
i, f = x

i = int(x[0])
f = int(x[1])

if i < f:
    t = f - i
else:
    t = (24 - i) + f
print('O JOGO DUROU {} HORA(S)'.format(t))

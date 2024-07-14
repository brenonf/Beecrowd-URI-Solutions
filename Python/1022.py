def mdc(a1, a2):
    while a2 != 0:
        a1, a2 = a2, a1 % a2
    return a1

a = int(input())
aux = []
for i in range(a):
    x=input()
    if '+' in x:
        x = list(map(int, x.replace('+', '/').split('/')))
        c = (x[0]*x[3]+x[1]*x[2])
        b=x[1]*x[3]
        print(f'{c}/{b} = {int(c/mdc(c,b))}/{int(b/mdc(c,b))}')

    elif '-' in x:
        x = list(map(int, x.replace('-', '/').split('/')))
        c = (x[0]*x[3]-x[1]*x[2])
        b=x[1]*x[3]
        print(f'{c}/{b} = {int(c/mdc(c,b))}/{int(b/mdc(c,b))}')

    elif '*' in x:
        x = list(map(int, x.replace('*', '/').split('/')))
        c = (x[0]*x[2])
        b=x[1]*x[3]
        print(f'{c}/{b} = {int(c/mdc(c,b))}/{int(b/mdc(c,b))}')

    else:
        x = list(map(int, x.replace('*', '/').split('/')))
        c=x[0]*x[3]
        b=x[1]*x[2]
        print(f'{c}/{b} = {int(c/mdc(c,b))}/{int(b/mdc(c,b))}')


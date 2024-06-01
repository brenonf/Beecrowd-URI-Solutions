x=100
y=1000

while x != y:
    x, y = map(int, input().split())
    if x > y:
        print('Decrescente')
    elif x < y:
        print('Crescente')

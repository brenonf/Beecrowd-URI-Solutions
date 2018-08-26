med = 0
x = 1
i=0
while x == 1:
    while i < 2:
        n = float(input())
        if n < 0.0 or n > 10.0:
            print('nota invalida')
        if n >= 0.0 and n <=10.0:
            med = med + n
            i = i + 1
    print('media = {:.2f}'.format(med / 2))

    while True:
        x = int(input('novo calculo (1-sim 2-nao)'))
        i =0
        med = 0
        if x == 2 or x == 1:
            break

while True:
    try:
        vol = float(input())
        d = float(input())
        a = 3.14 * (d / 2) ** 2
        h = vol / a
        print('ALTURA = {:.2f}'.format(h))
        print('AREA = {:.2f}'.format(a))
    except EOFError:
        break
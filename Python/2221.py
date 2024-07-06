def golpe(a,d,l,b):
    if l % 2 == 0:
        bonus = b
    else:
        bonus = 0
    g =(a + d) / 2 + bonus
    return g


def entrada():
    b = int(input())
    a1,d1,l1 = map(int,input().split())
    a2,d2,l2 = map(int,input().split())
    return b,a1,d1,l1,a2,d2,l2


def main():
    t = int(input())
    for i in range(t):
        b,a1,d1,l1,a2,d2,l2 = entrada()
        g1 = golpe(a1,d1,l1,b)
        g2 = golpe(a2,d2,l2,b)
        if g1 > g2:
            print('Dabriel')
        elif g1 < g2:
            print('Guarte')
        elif g1 == g2:
            print('Empate')

main()
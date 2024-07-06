def entrada():
    n = int(input())
    l = input().split()
    for i in range(n):
        l[i] = int(l[i])
    return l


def mult(l):
    m2 = 0
    m3 = 0
    m4 = 0
    m5 = 0
    for i in range(len(l)):
        if l[i] % 2 == 0:
            m2 += 1
        if l[i] % 3 == 0:
            m3 += 1
        if l[i] % 4 == 0:
            m4 += 1
        if l[i] % 5 == 0:
            m5 += 1
        m = dict()
        m[2] = m2
        m[3] = m3
        m[4] = m4
        m[5] = m5
    return m

def impressao(m):
    for i in m.keys():
        print('{} Multiplo(s) de {}'.format(m[i],i))


def main():
    #l = entrada()
    #m = mult(entrada)
    impressao(mult(entrada()))

main()
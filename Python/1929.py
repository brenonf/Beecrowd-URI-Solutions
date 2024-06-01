def verifica(a,b,c):
    if abs(b - c) < a < (b + c):
        if abs(a - c) < b < (a + c):
            if abs(a - b) < c < (a + b):
                return True
    else:
        return False


def entrada():
    a, b, c, d = map(int,input().split())
    return a, b, c, d


def forma_ou_nao(a,b,c,d):
    if verifica(a,b,c) or verifica(a,b,d) or verifica(a,c,d) or verifica(b,c,d):
        print('S')
    else:
        print('N')


def main():
    a, b, c, d = entrada()
    forma_ou_nao(a,b,c,d)

main()

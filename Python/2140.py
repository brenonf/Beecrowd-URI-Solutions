def entrada():
    n,m = map(int,input().split())
    troco = m - n
    return troco,m,n


def verificacao(troco):
    notas = [2,5,10,20,50,100]
    resultado = False
    for i in notas:
        for j in notas:
            if troco == i + j:
                resultado = True
    return resultado


def main():
    while True:
        troco,m,n = entrada()
        if m==0==n:
            break
        resultado = verificacao(troco)
        print('possible' if resultado == True else 'impossible')


main()

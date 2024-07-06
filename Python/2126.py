# Melhor usando count() e find()

def entrada():
        n1 = input()
        n2 = input()
        return n1,n2

def qtd(n1,n2):
    cont = 0
    ind = 0
    len1 = len(n1)
    len2 = len(n2)
    for i in range(len2):
        if n2[i] == n1[0] and n1 == n2[i:i + len1]:
            cont += 1
            ind = i + 1
    return cont, ind

def saida(cont, ind, caso):
    print('Caso #{}:'.format(caso))
    if cont == 0:
         print('Nao existe subsequencia')
    elif cont > 0:
        print('Qtd.Subsequencias: {}'.format(cont))
        print('Pos: {}'.format(ind))

def main():
    caso = 1
    while True:
        try:
            n1,n2 = entrada()
            cont, ind = qtd(n1,n2)
            saida(cont,ind,caso)
            caso += 1
            print()
        except EOFError:
            break

main()
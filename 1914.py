def entrada():
    x = input().split()
    soma = input().split()
    soma = int(soma[0]) + int(soma[1])
    return x, soma

def paridade(soma):
    if soma % 2 == 0:
        p = 'PAR'
    else:
        p = 'IMPAR'
    return p

def winner(p,x):
    y = x.index(p)
    if y == 1:
        win = x[0]
    elif y == 3:
        win = x[2]
    return win

def main():
    n = int(input())
    for i in range(n):
        x, soma = entrada()
        p = paridade(soma)
        print(winner(p,x))
    
main()

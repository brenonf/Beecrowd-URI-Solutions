def entrada():
    n = int(input())
    return n

def jogada():
    a = input()
    b = input()
    return a,b

def win(a,b,player):
    winner = 0
    if a == 'ataque' and b == 'pedra':
        winner = player
    elif a == 'pedra' and b == 'papel':
        winner = player
    elif a == 'ataque' and b == 'papel':
        winner = player
    elif a == 'papel' and b == 'papel':
        winner = 3
    elif a == 'pedra' and b =='pedra':
        winner = 0
    elif a == 'ataque' and b =='ataque':
        winner = 4

    return winner

def resultado(p1,p2):
    if p1 == 1:
        print('Jogador 1 venceu')
    elif p2 == 2:
        print('Jogador 2 venceu')
    elif p1 == 3 == p2:
        print('Ambos venceram')
    elif p1 == 0 == p2:
        print('Sem ganhador')
    elif p1 == 4 == p2:
        print('Aniquilacao mutua')

def main():
    n = entrada()
    for i in range(n):
        a,b = jogada()
        p1 = win(a,b,1)
        p2 = win(b,a,2)
        resultado(p1,p2)

main()
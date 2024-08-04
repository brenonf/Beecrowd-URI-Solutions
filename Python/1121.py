while True:
    n = list(map(int, input().split()))
    if n[0] == 0 and n[1] == 0 and n[2] == 0:
        break

    figuras = 0
    comandos = []
    sentido = 'x'
    linha = 0
    coluna = 0

    arena = []
    for i in range(n[0]):
        arena.append(list(input()))
        if sentido == 'x':
            if 'N' in arena[i]:
                sentido = 'N'
                linha = i
                coluna = arena[i].index('N')
            elif 'S' in arena[i]:
                sentido = 'S'
                linha = i
                coluna = arena[i].index('S')
            elif 'L' in arena[i]:
                sentido = 'L'
                linha = i
                coluna = arena[i].index('L')
            elif 'O' in arena[i]:
                sentido = 'O'
                linha = i
                coluna = arena[i].index('O')

    comandos = list(input())

    for comando in comandos:
        if comando == 'D':
            if sentido == 'N':
                sentido = 'L'
            elif sentido == 'S':
                sentido = 'O'
            elif sentido == 'L':
                sentido = 'S'
            elif sentido == 'O':
                sentido = 'N'
        elif comando == 'E':
            if sentido == 'N':
                sentido = 'O'
            elif sentido == 'S':
                sentido = 'L'
            elif sentido == 'L':
                sentido = 'N'
            elif sentido == 'O':
                sentido = 'S'
        else:
            if sentido == 'N':
                if linha - 1 >= 0 and arena[linha - 1][coluna] != '#':
                    linha -= 1
                    if arena[linha][coluna] == '*':
                        figuras += 1
                        arena[linha][coluna] = '.'
            elif sentido == 'S':
                if linha + 1 < n[0] and arena[linha + 1][coluna] != '#':
                    linha += 1
                    if arena[linha][coluna] == '*':
                        figuras += 1
                        arena[linha][coluna] = '.'
            elif sentido == 'L':
                if coluna + 1 < n[1] and arena[linha][coluna + 1] != '#':
                    coluna += 1
                    if arena[linha][coluna] == '*':
                        figuras += 1
                        arena[linha][coluna] = '.'
            elif sentido == 'O':
                if coluna - 1 >= 0 and arena[linha][coluna - 1] != '#':
                    coluna -= 1
                    if arena[linha][coluna] == '*':
                        figuras += 1
                        arena[linha][coluna] = '.'

    print(figuras)

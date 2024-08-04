while True:
    gp = list(map(int, input().split()))
    if gp[0] == 0 and gp[1] == 0:
        break

    colocacoes = [[] for _ in range(gp[1])]

    for _ in range(gp[0]):
        resultadoCorrida = list(map(int, input().split()))
        for j in range(gp[1]):
            colocacoes[j].append(resultadoCorrida[j])

    sistemas = int(input())
    for _ in range(sistemas):
        sistema = list(map(int, input().split()))
        pontuacaoPilotos = [0] * gp[1]
        
        for j in range(gp[1]):
            for s in range(1, sistema[0] + 1):
                pontuacaoPilotos[j] += sistema[s] * colocacoes[j].count(s)
        
        max_pontuacao = max(pontuacaoPilotos)
        indices_vencedores = []
        for indice in range(gp[1]):
            if pontuacaoPilotos[indice] == max_pontuacao:
                indices_vencedores.append(indice + 1)
        
        print(" ".join(map(str, indices_vencedores)))

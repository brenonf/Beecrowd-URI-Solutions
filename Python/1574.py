n = int(input())
movimentos = []
ponto = 0

for _ in range(n):
    m = int(input())
    for _ in range(m):
        movimento = input()
        
        if movimento == "LEFT":
            ponto -= 1
            movimentos.append("LEFT")
        elif movimento == "RIGHT":
            ponto += 1
            movimentos.append("RIGHT")
        else:
            indice = int(movimento.split()[2]) - 1
            movimento = movimentos[indice]
            if movimento == "LEFT":
                ponto -= 1
                movimentos.append("LEFT")
            elif movimento == "RIGHT":
                ponto += 1
                movimentos.append("RIGHT")
                
    print(ponto)
    movimentos.clear()
    ponto = 0

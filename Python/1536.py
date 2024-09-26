n = int(input())
for i in range(n):
    saldoGol1 = 0
    saldoGol2 = 0
    saldoCasa1 = 0
    saldoCasa2 = 0
    ponto1 = 0
    ponto2 = 0

    placar = input().split()
    gol1 = int(placar[0])
    gol2 = int(placar[2])
    saldoGol1 += gol1
    saldoGol2 += gol2
    saldoCasa2 += gol2
    if gol1 > gol2:
        ponto1 += 3
    elif gol2 > gol1:
        ponto2 += 3
    else:
        ponto1 += 1
        ponto2 += 1

    placar = input().split()
    gol1 = int(placar[2])
    gol2 = int(placar[0])
    saldoGol1 += gol1
    saldoGol2 += gol2
    saldoCasa1 += gol1
    if gol1 > gol2:
        ponto1 += 3
    elif gol2 > gol1:
        ponto2 += 3
    else:
        ponto1 += 1
        ponto2 += 1

    if ponto1 > ponto2:
        print("Time 1")
    elif ponto2 > ponto1:
        print("Time 2")
    else:
        if saldoGol1 > saldoGol2:
            print("Time 1")
        elif saldoGol2 > saldoGol1:
            print("Time 2")
        elif saldoCasa1 > saldoCasa2:
            print("Time 1")
        elif saldoCasa2 > saldoCasa1:
            print("Time 2")
        else:
            print("Penaltis")

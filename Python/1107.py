while True:
    entrada = input().split()
    altura = int(entrada[0])
    largura = int(entrada[1])

    if altura == 0 and largura == 0:
        break

    xxxx = input().split()
    passadas = 0
    comparacao = 0

    for i in range(largura):
        xi = int(xxxx[i])

        if i == 0:
            passadas += altura - xi
        elif xi < comparacao:
            passadas += comparacao - xi

        comparacao = xi

    print(passadas)

try:
    while True:
        cpf = input()
        if not cpf:
            break

        a1 = int(cpf[0])
        a2 = int(cpf[1])
        a3 = int(cpf[2])
        a4 = int(cpf[4])
        a5 = int(cpf[5])
        a6 = int(cpf[6])
        a7 = int(cpf[8])
        a8 = int(cpf[9])
        a9 = int(cpf[10])
        d1 = int(cpf[12])
        d2 = int(cpf[13])

        b1 = (a1 * 1 + a2 * 2 + a3 * 3 + a4 * 4 + a5 * 5 + a6 * 6 + a7 * 7 + a8 * 8 + a9 * 9) % 11
        b2 = (a1 * 9 + a2 * 8 + a3 * 7 + a4 * 6 + a5 * 5 + a6 * 4 + a7 * 3 + a8 * 2 + a9 * 1) % 11

        if b1 == 10:
            b1 = 0
        if b2 == 10:
            b2 = 0

        if b1 == d1 and b2 == d2:
            print("CPF valido")
        else:
            print("CPF invalido")
except EOFError:
    pass

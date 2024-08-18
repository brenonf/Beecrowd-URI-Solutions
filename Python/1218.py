caso = 1
while True:
    try:
        a = input().strip()
        if not a:
            break
        if caso > 1:
            print()

        lista = input().split()
        pares = 0
        m = 0
        f = 0

        for i in range(0, len(lista), 2):
            if lista[i] == a:
                pares += 1
                if lista[i + 1] == "M":
                    m += 1
                elif lista[i + 1] == "F":
                    f += 1

        print(f"Caso {caso}:")
        print(f"Pares Iguais: {pares}")
        print(f"F: {f}")
        print(f"M: {m}")
        caso += 1
        
    except EOFError:
        break

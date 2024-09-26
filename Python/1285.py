while True:
    try:
        x = input().strip()
        if not x:
            break

        n = list(map(int, x.split()))
        cont = 0
        aux = n[0]

        while aux <= n[1]:
            num_str = str(aux)
            if len(num_str) == len(set(num_str)):
                cont += 1
            aux += 1

        print(cont)
    except EOFError:
        break

while True:
    try:
        lista1 = list(map(int, input().split()))
        lista2 = set(map(int, input().split()))

        x = [str(i) for i in range(1, lista1[0] + 1) if i not in lista2]

        if x:
            print(" ".join(x)+" ")
        else:
            print("*")
    except EOFError:
        break

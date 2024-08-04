while True:
    n = input().split()
    if n[0] == "0" and n[1] == "0":
        break

    for i in range(2):
        while len(n[i]) != 1:
            algarismos = list(n[i])
            soma = 0
            for c in algarismos:
                soma += int(c)
            n[i] = str(soma)
    
    a = int(n[0])
    b = int(n[1])

    if a > b:
        print(1)
    elif a < b:
        print(2)
    else:
        print(0)

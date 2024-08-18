while True:
    try:
        x = input()
        if not x:
            break
        
        n = list(map(int, x.split()[1]))
        soma = sum(n)
        
        if soma % 3 == 0:
            print(f"{soma} sim")
        else:
            print(f"{soma} nao")
    except EOFError:
        break

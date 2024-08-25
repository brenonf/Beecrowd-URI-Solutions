impedido = False
while True:
    lista = list(map(int, input().split()))
    if lista[0] == 0 and lista[1] == 0:
        break

    a = sorted(map(int, input().split()), reverse=True)
    d = sorted(map(int, input().split()), reverse=True)
    for i in a:
        if (i < d[-2] and i < d[-1]) or (i < d[-2]):
            print("Y")
            impedido = True
            break


    if not impedido:
        print("N")
        
    impedido = False

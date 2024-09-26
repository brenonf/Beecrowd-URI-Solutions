while True:
    n = list(map(int, input().split()))
    if n[0] == 0 and n[1] == 0:
        break

    reservas = list(map(int, input().split()))
    for i in range(n[1]):
        deb = list(map(int, input().split()))
        reservas[deb[0] - 1] -= deb[2]
        reservas[deb[1] - 1] += deb[2]

    deubom = True
    for reserva in reservas:
        if reserva < 0:
            deubom = False
            print("N")
            break

    if deubom:
        print("S")

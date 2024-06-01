while True:
    try:
        n = int(input())
        x = input().split()
        m= 0
        for i in range(n):
            if int(x[i]) > m:
                m = int(x[i])

        if m < 10:
            N = 1
        elif m >= 10 and m < 20:
            N = 2
        else:
            N =3
        print(N)

    except EOFError:
        break


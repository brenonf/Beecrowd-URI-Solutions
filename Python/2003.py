while True:
    try:
        n = input().split(':')
        
        
        if int(n[0]) <= 6 or (int(n[0]) == 7 and int(n[1]) == 0):
            print('Atraso maximo: 0')
        else:
            n[0] = int(n[0]) + 1
            n[1] = int(n[1])
            h = n[0] - 8
            m = n[1]
            if h > 0:
                m += 60 * h
            print('Atraso maximo: {}'.format(m))






    except EOFError:
        break
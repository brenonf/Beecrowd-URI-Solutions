n = 9999

while True:
    n = int(input())
    if n <= 0:
        break
    if n > 0:
        m = []
        for i in range(0,n):
            m.append([])
            for j in range(0,n):
                m[i].append(0)
        if n % 2 == 0:
            t = n // 2 
        else:
            t = 1 + n // 2 

        min = 0
        max = n
        cont = 0
        for k in range(0,t):
            cont += 1
            for i in range(min,max):
                
                for j in range(min,max):
                    m[i][j] = cont
            min += 1
            max -= 1




    for i in range(0,n):
        for j in range(0,n):
            m[i][j] = str(m[i][j])
        M = '   '.join(m[i])
        print(' ',M)
    print()


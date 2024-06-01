def matriz():
    n = int(input())
    m = list()
    for i in range(n):
        m.append([])
        for j in range(n):
            m[i].append('0')
    return n,m

    
def diagonais(n,m):
    for i in range(n):
        m[i][i] = '2'
    for i in range(n):
        m[i][n - 1 - i] = '3'
    return m

    
def matriz_1(n,m):
    for i in range(n // 3,n - n // 3):
        for j in range(n // 3,n - n // 3):
            m[i][j] = '1'
    return m

            
def matriz_4(n,m):
    m[n // 2][n // 2] = '4'
    return m


def impressao(n,m):
    for i in range(n):
        M = ''.join(m[i])
        print(M)
    print()
        
        
def main():
    while True:
        try:
            n,m = matriz()
            m = diagonais(n,m)
            m = matriz_1(n,m)
            m = matriz_4(n,m)
            impressao(n,m)
        except EOFError:
            break

main()



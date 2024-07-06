def entrada():
    n, m = map(int,input().split())
    return n,m

def movimentos(n,m):
    for i in range(m):
        peri = input()
        if peri == 'clicou':
            n -= 1
        else:
            n += 1
    return n

def main():
    n,m = entrada()
    n = movimentos(n,m)
    print(n)

main()

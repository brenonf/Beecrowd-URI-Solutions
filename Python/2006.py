def entrada():
    n = int(input())
    t = input().split()
    for i in range(len(t)):
        t[i] = int(t[i])
    return t,n


def verificar(t,n):
    cont = 0
    for i in range(len(t)):
        if t[i] == n:
            cont += 1
    return cont

def main():
    t,n = entrada()
    print(verificar(t,n))

main()
        
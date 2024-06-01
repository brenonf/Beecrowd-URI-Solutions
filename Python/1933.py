def entrada():
    x,y = map(int,input().split())
    return x,y

def verificacao(a,b):
    if a == b:
        c = a
    elif a > b:
        c = a
    elif b > a:
        c = b
    return c

def main():
    x,y = entrada()
    c = verificacao(x,y)
    print(c)

main()

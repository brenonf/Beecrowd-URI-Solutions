def entrada():
    a,b,c,d = map(int,input().split())
    return a,b,c,d

def total(a,b,c,d):
    return a + b + c + d - 3

def main():
    a,b,c,d = entrada()
    print(total(a,b,c,d))

main()

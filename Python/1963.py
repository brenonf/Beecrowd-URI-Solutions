def entrada():
    a,b = map(float,input().split())
    
    return a,b

def aumento(a,b):
    p = 100 * ((b - a)/a)
    print('{:.2f}%'.format(p))

def main():
    a,b = entrada()
    aumento(a,b)

main()
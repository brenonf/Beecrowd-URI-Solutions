def entrada():
    n = int(input())
    x = list()
    for i in range(n):
        a = int(input())
        x.append(a)
    return x

def ano(x):
    for i in range(len(x)):
        if x[i] <= 2014:
            print('{} D.C.'.format(2015 - x[i]))
        if x[i] >= 2015:
            print('{} A.C.'.format(abs(2015 - x[i])+1))

def main():
    x = entrada()
    ano(x)

main()

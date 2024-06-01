def entrada():
    n = int(input())
    return n

def separacao(n):
    u = n % 10

    n //= 10
    d = n % 10

    n//= 10
    c = n % 10
    return c,d,u

def romanos(c,d,u):
    roma =''
    if c > 0:
        #centena
        if c <= 3:
            roma += 'C'*(c)
        elif c == 4:
            roma += 'CD'
        elif c == 5:
            roma += 'D'
        elif c > 5 and c < 9:
            roma += 'D' + 'C'*(c-5)
        elif c == 9:
            roma += 'CM'

    if d > 0:
        #dezena
        if d <= 3:
            roma += 'X'*(d)
        elif d == 4:
            roma += 'XL'
        elif d == 5:
            roma += 'L'
        elif d > 5 and d < 9:
            roma += 'L' + 'X'*(d-5)
        elif d == 9:
            roma += 'XC'
    if u > 0:
        #unidade
        if u <= 3:
            roma += 'I'*(u)
        elif u == 4:
            roma += 'IV'
        elif u == 5:
            roma += 'V'
        elif u > 5 and u < 9:
            roma += 'V' + 'I'*(u-5)
        elif u == 9:
            roma += 'IX'


    return roma

def main():
    c,d,u = separacao(entrada())
    print(romanos(c,d,u))

main()

def fibo(n):
    f = ((((1 + (5)**(1/2))/2) ** n - (((1 - (5)**(1/2))/2) ** n))) /(5 ** (1/2))
    return f

n = int(input())
print('{:.1f}'.format(fibo(n)))

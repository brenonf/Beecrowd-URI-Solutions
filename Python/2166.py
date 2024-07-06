n = int(input())
def raiz(n):
    if n == 1:
        return 1/(2 + 0)
    else:
        return 1/(2 + raiz(n-1))


if n ==0:
    r = 1.00
    print('{:.10f}'.format(r))

else:
    d = raiz(n)

    r = 1 + d

    print('{:.10f}'.format(r))

n = int(input())
def raiz(n):
    if n == 1:
        return 1/(6 + 0)
    else:
        return 1/(6 + raiz(n-1))


if n ==0:
    r = 3.00
    print('{:.10f}'.format(r))

else:
    d = raiz(n)

    r = 3 + d

    print('{:.10f}'.format(r))

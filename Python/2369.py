tudo = int(input())
n = tudo - 10
conta = 7

if tudo > 10:
    if n - 20 >= 0:
        conta += 20
        n -= 20
    else:
        conta += n

if tudo > 30:
    if n - 70 >= 0:
        conta += 70 * 2
        n -= 70
    else:
        conta += n * 2

if tudo > 100:
    conta += 5 * n

print(conta)

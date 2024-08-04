cont=1
while True:
    n = int(input())
    if n == 0:
        break
    a50 = n // 50
    n %= 50

    a10 = n // 10
    n %= 10

    a5 = n // 5
    n %= 5

    a1 = n
    
    print(f"Teste {cont}")
    print(f"{a50} {a10} {a5} {a1}")
    print()
    cont += 1

n = int(input())
for _ in range(n):
    tiros = int(input())
    tiro = list(map(int, input().split()))
    acoes = input().strip()
    cont = 0
    for t, a in zip(tiro, acoes):
        if (t <= 2 and a == 'S') or (t > 2 and a == 'J'):
            cont += 1
    
    
    
    print(cont)

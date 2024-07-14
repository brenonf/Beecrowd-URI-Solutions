x = m = 1

while True:
    x,m = map(int,input().split())
    if x == m == 0:
        break
    print(x * m)

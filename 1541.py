x = 99999
while True:
    x = input().split()
    if x == ['0']:
        break
    a,b,c = x

    a, b, c = int(a), int(b), int(c)
    
    
    A = a * b
    t = A *100 / c
    t = (t) ** (1/2)
    print(int(t))

t = 1
while t != 0:
    t = int(input())
    for i in range(t):
        n = int(input())
        if n % 2 == 0:
            print(2 * (n - 2) + 2)
        else:
            print(2 * (n - 1) + 1)
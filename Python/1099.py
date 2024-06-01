n = int(input())
d = 0

for c in range(1 , n + 1):
    x = input().split()
    a, b, = x
    s=0
    a = int(a)
    b = int(b)

    if a > b:
        for d in range(int(b)+1, int(a)):
            if d % 2 != 0:
                s = s + d
    if a < b:
        for d in range(int(a)+1, int(b)):
            if d % 2 != 0:
                s = s + d
    if a == b:
        s = 0
    print(s)

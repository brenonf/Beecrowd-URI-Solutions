n = int(input())

for i in range(1 , n + 1 ):
    x = input().split()
    a,b,c = x
    print('{:.1f}'.format((float(a) * 2 + float(b) * 3 + float(c) * 5) / 10))

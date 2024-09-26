n = int(input())
x = list(map(int, input().split()))
zero = x.count(0)

if zero > n / 2:
    print("Y")
else:
    print("N")

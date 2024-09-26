n = int(input())
lava = list(map(int, input().split()))
seca = list(map(int, input().split()))


if lava[0] <= n <= lava[1] and seca[0] <= n <= seca[1]:
    print("possivel")
else:
    print("impossivel")

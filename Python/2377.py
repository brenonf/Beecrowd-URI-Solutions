x = list(map(int, input().split()))
y = list(map(int, input().split()))

result = (x[0] // x[1]) * y[1] + x[0] * y[0]


print(result)

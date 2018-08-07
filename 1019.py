n = int(input())
h = n // 60**2
n = n - h * 60**2

m = n // 60
n = n - m*60

s = n

print('{}:{}:{}'.format(h, m, s))

n = int(input())

h = input().split()

x =1

for i in range(n):
    h[i] =int(h[i])

if h[0] > h[1]:
    lugar = 'pico'
else:
    lugar = 'vale'


if lugar == 'pico':
    for i in range(n - 1):
        if i % 2 == 0:
            if h[i] > h[i+1]:
                x = 1
            else:
                x = 0
                break
        else:
            if h[i] < h[i+1]:
                x = 1
            else:
                x = 0
                break
            

if lugar == 'vale':
    for i in range(n - 1):
        if i % 2 == 0:
            if h[i] < h[i+1]:
                x = 1
            else:
                x = 0
                break
        else:
            if h[i] > h[i+1]:
                x = 1
            else:
                x = 0
                break

print(x)

n = int(input())

for i in range(0,n):
    num = int(input())
    s = 0
    j=1
    while j <= num:
        if num % j == 0:
            s = s + 1
        j = j + 1
    if s > 2:
        print('{} nao eh primo'.format(num))
    else:
        print('{} eh primo'.format(num))
        
